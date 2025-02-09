namespace HotelBookingApp
{
    partial class UserPage
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
            dataGridView1 = new DataGridView();
            lbl_fullname = new Label();
            lbl_username = new Label();
            lbl_password = new Label();
            lbl_role = new Label();
            lbl_phone = new Label();
            lbl_email = new Label();
            txt_fullname = new TextBox();
            txt_username = new TextBox();
            txt_password = new TextBox();
            combo_role = new ComboBox();
            txt_email = new TextBox();
            txt_phone = new TextBox();
            btn_register = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            lbl_userid = new Label();
            lbl_useridvalue = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 227);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbl_fullname
            // 
            lbl_fullname.AutoSize = true;
            lbl_fullname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_fullname.Location = new Point(23, 293);
            lbl_fullname.Name = "lbl_fullname";
            lbl_fullname.Size = new Size(82, 21);
            lbl_fullname.TabIndex = 1;
            lbl_fullname.Text = "Full Name";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_username.Location = new Point(23, 359);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(83, 21);
            lbl_username.TabIndex = 2;
            lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_password.Location = new Point(23, 425);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(79, 21);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Password";
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_role.Location = new Point(263, 293);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(43, 21);
            lbl_role.TabIndex = 4;
            lbl_role.Text = "Role";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_phone.Location = new Point(263, 359);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(56, 21);
            lbl_phone.TabIndex = 5;
            lbl_phone.Text = "Phone";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_email.Location = new Point(263, 425);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(48, 21);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "Email";
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(23, 317);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(187, 23);
            txt_fullname.TabIndex = 7;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(23, 383);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(187, 23);
            txt_username.TabIndex = 8;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(23, 449);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(187, 23);
            txt_password.TabIndex = 9;
            // 
            // combo_role
            // 
            combo_role.FormattingEnabled = true;
            combo_role.Location = new Point(263, 317);
            combo_role.Name = "combo_role";
            combo_role.Size = new Size(121, 23);
            combo_role.TabIndex = 10;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(263, 449);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(187, 23);
            txt_email.TabIndex = 11;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(263, 383);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(187, 23);
            txt_phone.TabIndex = 12;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_register.Location = new Point(502, 306);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(286, 50);
            btn_register.TabIndex = 13;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_edit.Location = new Point(502, 368);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(286, 49);
            btn_edit.TabIndex = 14;
            btn_edit.Text = "Save Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btn_delete.Location = new Point(502, 445);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(286, 43);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // lbl_userid
            // 
            lbl_userid.AutoSize = true;
            lbl_userid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_userid.Location = new Point(23, 253);
            lbl_userid.Name = "lbl_userid";
            lbl_userid.Size = new Size(71, 21);
            lbl_userid.TabIndex = 16;
            lbl_userid.Text = "User ID :";
            // 
            // lbl_useridvalue
            // 
            lbl_useridvalue.AutoSize = true;
            lbl_useridvalue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_useridvalue.Location = new Point(100, 253);
            lbl_useridvalue.Name = "lbl_useridvalue";
            lbl_useridvalue.Size = new Size(19, 21);
            lbl_useridvalue.TabIndex = 17;
            lbl_useridvalue.Text = "0";
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(lbl_useridvalue);
            Controls.Add(lbl_userid);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_register);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(combo_role);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(txt_fullname);
            Controls.Add(lbl_email);
            Controls.Add(lbl_phone);
            Controls.Add(lbl_role);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(lbl_fullname);
            Controls.Add(dataGridView1);
            Name = "UserPage";
            Text = "UserPage";
            Load += UserPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_fullname;
        private Label lbl_username;
        private Label lbl_password;
        private Label lbl_role;
        private Label lbl_phone;
        private Label lbl_email;
        private TextBox txt_fullname;
        private TextBox txt_username;
        private TextBox txt_password;
        private ComboBox combo_role;
        private TextBox txt_email;
        private TextBox txt_phone;
        private Button btn_register;
        private Button btn_edit;
        private Button btn_delete;
        private Label lbl_userid;
        private Label lbl_useridvalue;
    }
}