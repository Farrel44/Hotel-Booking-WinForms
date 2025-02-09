using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserPage : Form
    {

        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Connection connection = new Connection();
        Encrypt encryption = new Encrypt();
        public UserPage()
        {
            InitializeComponent();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            combo_role.Items.Clear();
            combo_role.Items.Add("admin");
            combo_role.Items.Add("receptionist");
            combo_role.Items.Add("manager");
            combo_role.SelectedIndex = 0;
            ShowData();
        }

        void ShowData()
        {
            SqlConnection conn = connection.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT user_id, full_name, password_hash, username, role, phone, email FROM users", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "users");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "users";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["user_id"].Visible = false;
            dataGridView1.Columns["password_hash"].Visible = false;
            conn.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string fullName = txt_fullname.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            string role = combo_role.SelectedItem.ToString();
            string phone = txt_phone.Text;
            string email = txt_email.Text;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = encryption.PashHash(password);

            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username OR email = @email";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@email", email);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username or Email already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertQuery = "INSERT INTO users (full_name, username, password_hash, role, phone, email) VALUES (@full_name, @username, @password_hash, @role, @phone, @email)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@full_name", fullName);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password_hash", hashedPassword);
                    insertCmd.Parameters.AddWithValue("@role", role);
                    insertCmd.Parameters.AddWithValue("@phone", phone);
                    insertCmd.Parameters.AddWithValue("@email", email);
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registration Succesfull!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_fullname.Text = row.Cells["full_name"].Value.ToString();
                txt_username.Text = row.Cells["username"].Value.ToString();
                txt_phone.Text = row.Cells["phone"].Value.ToString();
                txt_email.Text = row.Cells["email"].Value.ToString();
                combo_role.SelectedItem = row.Cells["role"].Value.ToString();
                lbl_useridvalue.Text = row.Cells["user_id"].Value.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string userId = lbl_useridvalue.Text;
            string fullName = txt_fullname.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            string role = combo_role.SelectedItem.ToString();
            string phone = txt_phone.Text;
            string email = txt_email.Text;

            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();

                string updateQuery = "UPDATE users SET full_name = @full_name, username = @username, role = @role, phone = @phone, email = @email WHERE user_id = @user_id";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@full_name", fullName);
                    updateCmd.Parameters.AddWithValue("@username", username);
                    updateCmd.Parameters.AddWithValue("@role", role);
                    updateCmd.Parameters.AddWithValue("@phone", phone);
                    updateCmd.Parameters.AddWithValue("@email", email);
                    updateCmd.Parameters.AddWithValue("@user_id", userId);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string userId = lbl_useridvalue.Text;
            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("Select the user you want to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                string deleteQuery = "DELETE FROM users WHERE user_id = @user_id";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@user_id", userId);
                    deleteCmd.ExecuteNonQuery();
                }
                MessageBox.Show("User successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
        }
    }
}
