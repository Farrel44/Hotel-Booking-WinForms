namespace HotelBookingApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_username = new Label();
            lbl_password = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            lbl_title = new Label();
            check_pass = new CheckBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_username.Location = new Point(48, 69);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(83, 21);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_password.Location = new Point(48, 149);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(79, 21);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(48, 93);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(247, 23);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(48, 173);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(247, 23);
            txt_password.TabIndex = 4;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lbl_title.Location = new Point(128, 20);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(74, 32);
            lbl_title.TabIndex = 5;
            lbl_title.Text = "Login";
            // 
            // check_pass
            // 
            check_pass.AutoSize = true;
            check_pass.Location = new Point(52, 205);
            check_pass.Name = "check_pass";
            check_pass.Size = new Size(108, 19);
            check_pass.TabIndex = 6;
            check_pass.Text = "Show Password";
            check_pass.UseVisualStyleBackColor = true;
            check_pass.CheckedChanged += check_pass_CheckedChanged;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(128, 266);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(87, 34);
            btn_login.TabIndex = 7;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 346);
            Controls.Add(btn_login);
            Controls.Add(check_pass);
            Controls.Add(lbl_title);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_username;
        private Label lbl_password;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label lbl_title;
        private CheckBox check_pass;
        private Button btn_login;
    }
}