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
    public partial class ReportPage : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        private Connection connection = new Connection();

        public ReportPage()
        {
            InitializeComponent();
        }

        private void ReportPage_Load(object sender, EventArgs e)
        {
            LoadPaymentReport();
        }

        private void LoadPaymentReport()
        {
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("SELECT payment_id, reservation_id, amount, payment_method, payment_status, payment_date FROM payments", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "payments");
                dataGridViewPayments.DataSource = ds;
                dataGridViewPayments.DataMember = "payments";
                dataGridViewPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = connection.GetConn())
            {
                conn.Open();
                cmd = new SqlCommand("SELECT payment_id, reservation_id, amount, payment_method, payment_status, payment_date FROM payments WHERE payment_date BETWEEN @startDate AND @endDate", conn);
                cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value);
                cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "payments");
                dataGridViewPayments.DataSource = ds;
                dataGridViewPayments.DataMember = "payments";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Save Report"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in dataGridViewPayments.Rows)
                    {
                        string line = "";
                        for (int i = 0; i < dataGridViewPayments.ColumnCount; i++)
                        {
                            line += row.Cells[i].Value?.ToString() + ",";
                        }
                        file.WriteLine(line.TrimEnd(','));
                    }
                }
                MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
