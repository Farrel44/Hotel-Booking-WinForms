using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingApp
{
    public partial class ReservationPage : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        private Connection connection = new Connection();

        public ReservationPage()
        {
            InitializeComponent();
        }

        private void ReservationPage_Load(object sender, EventArgs e)
        {
            ShowReservations();
            ShowAvailableRooms();
        }

        void ShowReservations()
        {
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("SELECT r.reservation_id, g.full_name, rm.room_number, r.check_in_date, r.check_out_date, r.status FROM reservations r JOIN guests g ON r.guest_id = g.guest_id JOIN rooms rm ON r.room_id = rm.room_id", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "reservations");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "reservations";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        void ShowAvailableRooms()
        {
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("SELECT room_id, room_number FROM rooms WHERE status = 'available'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "available_rooms");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "available_rooms";
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_guestId.Text) || string.IsNullOrWhiteSpace(txt_roomId.Text))
            {
                MessageBox.Show("Please select a guest and a room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpCheckIn.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Check-in date cannot be before today.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO reservations (guest_id, room_id, check_in_date, check_out_date) VALUES (@guest_id, @room_id, @check_in_date, @check_out_date)", conn);
                cmd.Parameters.AddWithValue("@guest_id", txt_guestId.Text);
                cmd.Parameters.AddWithValue("@room_id", txt_roomId.Text);
                cmd.Parameters.AddWithValue("@check_in_date", dtpCheckIn.Value);
                cmd.Parameters.AddWithValue("@check_out_date", dtpCheckOut.Value);
                cmd.ExecuteNonQuery();
            }
            ShowReservations();
            ShowAvailableRooms();
        }

        private void btn_checkIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_reservationId.Text))
            {
                MessageBox.Show("Please select a reservation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE reservations SET status = 'checked_in' WHERE reservation_id = @reservation_id AND status = 'confirmed'", conn);
                cmd.Parameters.AddWithValue("@reservation_id", txt_reservationId.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Reservation must be confirmed before check-in.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            ShowReservations();
        }

        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_reservationId.Text))
            {
                MessageBox.Show("Please select a reservation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_amount.Text) || !decimal.TryParse(txt_amount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE reservations SET status = 'checked_out' WHERE reservation_id = @reservation_id AND status = 'checked_in'", conn);
                cmd.Parameters.AddWithValue("@reservation_id", txt_reservationId.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Only checked-in reservations can be checked out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmd = new SqlCommand("INSERT INTO payments (reservation_id, amount, payment_method, payment_status) VALUES (@reservation_id, @amount, @payment_method, 'paid')", conn);
                cmd.Parameters.AddWithValue("@reservation_id", txt_reservationId.Text);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@payment_method", cmbPaymentMethod.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
            }
            ShowReservations();
            ShowAvailableRooms();
        }

        private void btn_cancelReservation_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE reservations SET status = 'canceled' WHERE reservation_id = @reservation_id", conn);
                cmd.Parameters.AddWithValue("@reservation_id", txt_reservationId.Text);
                cmd.ExecuteNonQuery();
            }
            ShowReservations();
            ShowAvailableRooms();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_reservationId.Text = row.Cells["reservation_id"].Value.ToString();
                txt_guestId.Text = row.Cells["full_name"].Value.ToString();
                txt_roomId.Text = row.Cells["room_number"].Value.ToString();
                dtpCheckIn.Value = Convert.ToDateTime(row.Cells["check_in_date"].Value);
                dtpCheckOut.Value = Convert.ToDateTime(row.Cells["check_out_date"].Value);
                cmbStatus.SelectedItem = row.Cells["status"].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                txt_roomId.Text = row.Cells["room_id"].Value.ToString();
            }
        }
    }
}
