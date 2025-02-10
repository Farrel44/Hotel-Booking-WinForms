namespace HotelBookingApp
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Welcome = new Label();
            btn_Login = new Button();
            btn_userpage = new Button();
            btn_roompage = new Button();
            btn_guestpage = new Button();
            btn_reservation = new Button();
            btn_report = new Button();
            lbl_WelcomeRole = new Label();
            lbl_credit = new Label();
            btn_out = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Welcome.Location = new Point(36, 9);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(725, 45);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "Selamat Datang! Silahkan login terlebih dahulu";
            lbl_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(320, 152);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(141, 80);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_userpage
            // 
            btn_userpage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_userpage.Location = new Point(78, 83);
            btn_userpage.Name = "btn_userpage";
            btn_userpage.Size = new Size(176, 80);
            btn_userpage.TabIndex = 2;
            btn_userpage.Text = "User Management";
            btn_userpage.UseVisualStyleBackColor = true;
            btn_userpage.Click += btn_UserPage_Click;
            // 
            // btn_roompage
            // 
            btn_roompage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_roompage.Location = new Point(305, 83);
            btn_roompage.Name = "btn_roompage";
            btn_roompage.Size = new Size(176, 80);
            btn_roompage.TabIndex = 3;
            btn_roompage.Text = "Room Management";
            btn_roompage.UseVisualStyleBackColor = true;
            btn_roompage.Click += btn_roompage_Click;
            // 
            // btn_guestpage
            // 
            btn_guestpage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guestpage.Location = new Point(530, 83);
            btn_guestpage.Name = "btn_guestpage";
            btn_guestpage.Size = new Size(176, 80);
            btn_guestpage.TabIndex = 4;
            btn_guestpage.Text = "Guest Management";
            btn_guestpage.UseVisualStyleBackColor = true;
            btn_guestpage.Click += btn_guestpage_Click;
            // 
            // btn_reservation
            // 
            btn_reservation.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reservation.Location = new Point(195, 208);
            btn_reservation.Name = "btn_reservation";
            btn_reservation.Size = new Size(179, 80);
            btn_reservation.TabIndex = 5;
            btn_reservation.Text = "Room Reservation";
            btn_reservation.UseVisualStyleBackColor = true;
            btn_reservation.Click += btn_reservation_Click;
            // 
            // btn_report
            // 
            btn_report.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_report.Location = new Point(409, 208);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(176, 80);
            btn_report.TabIndex = 6;
            btn_report.Text = "Transaction Reports";
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // lbl_WelcomeRole
            // 
            lbl_WelcomeRole.AutoSize = true;
            lbl_WelcomeRole.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_WelcomeRole.Location = new Point(11, 9);
            lbl_WelcomeRole.Name = "lbl_WelcomeRole";
            lbl_WelcomeRole.Size = new Size(178, 37);
            lbl_WelcomeRole.TabIndex = 7;
            lbl_WelcomeRole.Text = "Logged in as ";
            // 
            // lbl_credit
            // 
            lbl_credit.AutoSize = true;
            lbl_credit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_credit.Location = new Point(12, 338);
            lbl_credit.Name = "lbl_credit";
            lbl_credit.Size = new Size(188, 25);
            lbl_credit.TabIndex = 8;
            lbl_credit.Text = "Hotel Telkom 2025 ©";
            // 
            // btn_out
            // 
            btn_out.BackColor = Color.Red;
            btn_out.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_out.ForeColor = SystemColors.ControlLightLight;
            btn_out.Location = new Point(710, 322);
            btn_out.Name = "btn_out";
            btn_out.Size = new Size(91, 41);
            btn_out.TabIndex = 9;
            btn_out.Text = "Log Out";
            btn_out.UseVisualStyleBackColor = false;
            btn_out.Click += btn_out_Click;
            // 
            // btn_exit
            // 
            btn_exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_exit.BackColor = Color.Red;
            btn_exit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = SystemColors.ControlLightLight;
            btn_exit.Location = new Point(710, 319);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(91, 41);
            btn_exit.TabIndex = 10;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 372);
            Controls.Add(btn_exit);
            Controls.Add(btn_out);
            Controls.Add(lbl_credit);
            Controls.Add(lbl_WelcomeRole);
            Controls.Add(btn_report);
            Controls.Add(btn_reservation);
            Controls.Add(btn_guestpage);
            Controls.Add(btn_roompage);
            Controls.Add(btn_userpage);
            Controls.Add(btn_Login);
            Controls.Add(lbl_Welcome);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Welcome;
        private Button btn_Login;
        private Button btn_userpage;
        private Button btn_roompage;
        private Button btn_guestpage;
        private Button btn_reservation;
        private Button btn_report;
        private Label lbl_WelcomeRole;
        private Label lbl_credit;
        private Button btn_out;
        public Button btn_exit;
    }
}
