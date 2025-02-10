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
            ShowGuests();
            PopulatePaymentMethods();
            PopulateStatusReservation();
        }

        private void PopulatePaymentMethods()
        {
            cmbPaymentMethod.Items.Add("cash");
            cmbPaymentMethod.Items.Add("credit_card");
            cmbPaymentMethod.Items.Add("debit_card");
            cmbPaymentMethod.Items.Add("bank_transfer");
        }

        private void PopulateStatusReservation()
        {
            cmbStatus.Items.Add("checked_in");
            cmbStatus.Items.Add("checked_out");
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
                dataGridViewReservations.DataSource = ds;
                dataGridViewReservations.DataMember = "reservations";
                dataGridViewReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        void ShowAvailableRooms()
        {
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("SELECT room_id, room_number, price FROM rooms WHERE status = 'available'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "available_rooms");
                dataGridViewRooms.DataSource = ds;
                dataGridViewRooms.DataMember = "available_rooms";
                dataGridViewRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        void ShowGuests()
        {
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("SELECT guest_id, full_name FROM guests", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "guests");
                dataGridViewGuests.DataSource = ds;
                dataGridViewGuests.DataMember = "guests";
                dataGridViewGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btn_book_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_guestId.Text) || string.IsNullOrWhiteSpace(txt_roomId.Text))
            {
                MessageBox.Show("Please select a guest and a room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    cmd = new SqlCommand("INSERT INTO reservations (guest_id, room_id, check_in_date, check_out_date) VALUES (@guest_id, @room_id, @check_in_date, @check_out_date)", conn, transaction);
                    cmd.Parameters.AddWithValue("@guest_id", txt_guestId.Text);
                    cmd.Parameters.AddWithValue("@room_id", txt_roomId.Text);
                    cmd.Parameters.AddWithValue("@check_in_date", dtpCheckIn.Value);
                    cmd.Parameters.AddWithValue("@check_out_date", dtpCheckOut.Value);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("UPDATE rooms SET status = 'occupied' WHERE room_id = @room_id", conn, transaction);
                    cmd.Parameters.AddWithValue("@room_id", txt_roomId.Text);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Room successfully booked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while booking the room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ShowReservations();
            ShowAvailableRooms();
        }

        private void btn_processPayment_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_reservationId.Text) || string.IsNullOrWhiteSpace(txt_amount.Text) || cmbPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Please provide complete payment details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    cmd = new SqlCommand("INSERT INTO payments (reservation_id, amount, payment_method, payment_status) VALUES (@reservation_id, @amount, @payment_method, 'paid')", conn, transaction);
                    cmd.Parameters.AddWithValue("@reservation_id", txt_reservationId.Text);
                    cmd.Parameters.AddWithValue("@amount", decimal.Parse(txt_amount.Text));
                    cmd.Parameters.AddWithValue("@payment_method", cmbPaymentMethod.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("UPDATE reservations SET status = 'confirmed' WHERE reservation_id = @reservation_id", conn, transaction);
                    cmd.Parameters.AddWithValue("@reservation_id", txt_reservationId.Text);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Payment processed successfully and reservation confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while processing the payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ShowReservations();
        }

        private void btn_cancelReservation_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_reservationId.Text))
            {
                MessageBox.Show("Please select a reservation to cancel.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE reservations SET status = 'canceled' WHERE reservation_id = @reservation_id", conn);
                cmd.Parameters.AddWithValue("@reservation_id", txt_reservationId.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Reservation canceled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowReservations();
            ShowAvailableRooms();
        }

        private void dataGridViewReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewReservations.Rows[e.RowIndex];
                txt_reservationId.Text = row.Cells["reservation_id"].Value.ToString();
                txt_guestId.Text = row.Cells["full_name"].Value.ToString();
                txt_roomId.Text = row.Cells["room_number"].Value.ToString();
                dtpCheckIn.Value = Convert.ToDateTime(row.Cells["check_in_date"].Value);
                dtpCheckOut.Value = Convert.ToDateTime(row.Cells["check_out_date"].Value);
            }
        }

        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRooms.Rows[e.RowIndex];
                txt_roomId.Text = row.Cells["room_id"].Value.ToString();
            }
        }

        private void dataGridViewGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewGuests.Rows[e.RowIndex];
                txt_guestId.Text = row.Cells["guest_id"].Value.ToString();
            }
        }

        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRooms.Rows[e.RowIndex];
                txt_roomId.Text = row.Cells["room_id"].Value.ToString();
                txt_amount.Text = row.Cells["price"].Value.ToString();
            }
        }

        private void dataGridViewGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewGuests.Rows[e.RowIndex];
                txt_guestId.Text = row.Cells["guest_id"].Value.ToString();
            }
        }

        private void dataGridViewReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewReservations.Rows[e.RowIndex];
                txt_reservationId.Text = row.Cells["reservation_id"].Value.ToString();
                txt_guestId.Text = row.Cells["full_name"].Value.ToString();
                txt_roomId.Text = row.Cells["room_number"].Value.ToString();
                dtpCheckIn.Value = Convert.ToDateTime(row.Cells["check_in_date"].Value);
                dtpCheckOut.Value = Convert.ToDateTime(row.Cells["check_out_date"].Value);
            }
        }

        private void btn_updateStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_reservationId.Text) || cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a reservation and status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    cmd = new SqlCommand("UPDATE reservations SET status = @status WHERE reservation_id = @reservation_id", conn, transaction);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@reservation_id", txt_reservationId.Text);
                    cmd.ExecuteNonQuery();

                    if (cmbStatus.SelectedItem.ToString() == "check-out")
                    {
                        cmd = new SqlCommand("UPDATE rooms SET status = 'maintenance' WHERE room_number = (SELECT rm.room_number FROM reservations r JOIN rooms rm ON r.room_id = rm.room_id WHERE r.reservation_id = @reservation_id)", conn, transaction);
                        cmd.Parameters.AddWithValue("@reservation_id", txt_reservationId.Text);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Reservation status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while updating the reservation status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ShowReservations();
            ShowAvailableRooms();
        }
    }
}
