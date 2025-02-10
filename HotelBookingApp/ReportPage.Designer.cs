namespace HotelBookingApp
{
    partial class ReportPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewPayments = new DataGridView();
            btnFilter = new Button();
            btnExport = new Button();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblStartDate = new Label();
            lblEndDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayments.Location = new Point(12, 50);
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.Size = new Size(797, 300);
            dataGridViewPayments.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(654, 12);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 1;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(734, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(100, 12);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(380, 12);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(259, 23);
            dtpEndDate.TabIndex = 4;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(12, 15);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(58, 15);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(320, 15);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(54, 15);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "End Date";
            // 
            // ReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 377);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnExport);
            Controls.Add(btnFilter);
            Controls.Add(dataGridViewPayments);
            Name = "ReportPage";
            Text = "Payment Report";
            Load += ReportPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}