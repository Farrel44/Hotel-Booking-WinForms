using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelBookingApp
{
    public partial class RoomPage : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        Connection connection = new Connection();
        public RoomPage()
        {
            InitializeComponent();
        }

        private void RoomPage_Load(object sender, EventArgs e)
        {
            ShowData();
            cmbroomtype.Items.AddRange(new string[] { "single", "double", "suite", "deluxe" });
            cmbstatus.Items.AddRange(new string[] { "available", "occupied", "maintenance" });
            cmbroomtype.SelectedIndex = 0;
            cmbstatus.SelectedIndex = 0;
        }

        void ClearData()
        {
            txt_roomprice.Text = "";
            txt_roomnumber.Text = "";
            cmbroomtype.SelectedIndex = 0;
            cmbstatus.SelectedIndex = 0;
        }

        void ShowData()
        {
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("SELECT room_id, room_number, type, price, status FROM rooms", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "rooms");
                dataGridView1.DataSource = ds.Tables["rooms"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["room_id"].Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_roomnumber.Text = row.Cells["room_number"].Value.ToString();
                txt_roomprice.Text = row.Cells["price"].Value.ToString();
                cmbroomtype.SelectedItem = row.Cells["type"].Value.ToString();
                cmbstatus.SelectedItem = row.Cells["status"].Value.ToString();
                lbl_roomidvalue.Text = row.Cells["room_id"].Value.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string roomNumber = txt_roomnumber.Text;
            string type = cmbroomtype.SelectedItem.ToString();
            decimal price = Convert.ToDecimal(txt_roomprice.Text);
            string status = cmbstatus.SelectedItem.ToString();
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM rooms WHERE room_number = @room_number";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@room_number", roomNumber);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Room number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertQuery = "INSERT INTO rooms (room_number, type, price, status) VALUES (@room_number, @type, @price, @status)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@room_number", roomNumber);
                    insertCmd.Parameters.AddWithValue("@type", type);
                    insertCmd.Parameters.AddWithValue("@price", price);
                    insertCmd.Parameters.AddWithValue("@status", status);
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int roomId = Convert.ToInt32(lbl_roomidvalue.Text);
            string roomNumber = txt_roomnumber.Text;
            string type = cmbroomtype.SelectedItem.ToString();
            decimal price = Convert.ToDecimal(txt_roomprice.Text);
            string status = cmbstatus.SelectedItem.ToString();

            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE rooms SET room_number = @room_number, type = @type, price = @price, status = @status WHERE room_id = @room_id", conn);
                cmd.Parameters.AddWithValue("@room_id", roomId);
                cmd.Parameters.AddWithValue("@room_number", roomNumber);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Room details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
            ShowData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int roomId = Convert.ToInt32(lbl_roomidvalue.Text);
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM rooms WHERE room_id = @room_id", conn);
                cmd.Parameters.AddWithValue("@room_id", roomId);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
            ShowData();
        }
    }
}
