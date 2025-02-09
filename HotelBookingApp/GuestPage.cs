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
    public partial class GuestPage : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        Connection connection = new Connection();
        public GuestPage()
        {
            InitializeComponent();
        }

        private void GuestPage_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            SqlConnection conn = connection.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT guest_id, full_name, phone, email, address, id_card_number FROM guests", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "guests");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "guests";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                lbl_guestid_value.Text = row.Cells["guest_id"].Value.ToString();
                txt_fullname.Text = row.Cells["full_name"].Value.ToString();
                txt_phone.Text = row.Cells["phone"].Value.ToString();
                txt_email.Text = row.Cells["email"].Value.ToString();
                txt_address.Text = row.Cells["address"].Value.ToString();
                txt_cardnumber.Text = row.Cells["id_card_number"].Value.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string fullName = txt_fullname.Text;
            string phone = txt_phone.Text;
            string email = txt_email.Text;
            string address = txt_address.Text;
            string idCardNumber = txt_cardnumber.Text;

            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM guests WHERE id_card_number = @id_card_number";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@id_card_number", idCardNumber);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Guest with this ID Card Number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertQuery = "INSERT INTO guests (full_name, phone, email, address, id_card_number) VALUES (@full_name, @phone, @email, @address, @id_card_number)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@full_name", fullName);
                    insertCmd.Parameters.AddWithValue("@phone", phone);
                    insertCmd.Parameters.AddWithValue("@email", email);
                    insertCmd.Parameters.AddWithValue("@address", address);
                    insertCmd.Parameters.AddWithValue("@id_card_number", idCardNumber);
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Guest added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int guestId = Convert.ToInt32(lbl_guestid_value.Text);
            string fullName = txt_fullname.Text;
            string phone = txt_phone.Text;
            string email = txt_email.Text;
            string address = txt_address.Text;
            string idCardNumber = txt_cardnumber.Text;

            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE guests SET full_name = @full_name, phone = @phone, email = @email, address = @address, id_card_number = @id_card_number WHERE guest_id = @guest_id", conn);
                cmd.Parameters.AddWithValue("@guest_id", guestId);
                cmd.Parameters.AddWithValue("@full_name", fullName);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@id_card_number", idCardNumber);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Guest details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int guestId = Convert.ToInt32(lbl_guestid_value.Text);
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM guests WHERE guest_id = @guest_id", conn);
                cmd.Parameters.AddWithValue("@guest_id", guestId);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Guest deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowData();
        }
    }
}
