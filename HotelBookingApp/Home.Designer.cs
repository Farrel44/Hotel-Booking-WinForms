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
            SuspendLayout();
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Welcome.Location = new Point(195, 9);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(408, 25);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "Selamat Datang! Silahkan login terlebih dahulu";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(321, 358);
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
            btn_reservation.Location = new Point(195, 218);
            btn_reservation.Name = "btn_reservation";
            btn_reservation.Size = new Size(396, 80);
            btn_reservation.TabIndex = 5;
            btn_reservation.Text = "Room Reservation";
            btn_reservation.UseVisualStyleBackColor = true;
            btn_reservation.Click += btn_reservation_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
