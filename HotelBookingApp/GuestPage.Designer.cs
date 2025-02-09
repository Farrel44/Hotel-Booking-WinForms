namespace HotelBookingApp
{
    partial class GuestPage
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
            lbl_phone = new Label();
            lbl_email = new Label();
            lbl_address = new Label();
            lbl_id_card_number = new Label();
            txt_fullname = new TextBox();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            txt_cardnumber = new TextBox();
            txt_address = new TextBox();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            lbl_guest_id = new Label();
            lbl_guestid_value = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(708, 230);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbl_fullname
            // 
            lbl_fullname.AutoSize = true;
            lbl_fullname.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_fullname.Location = new Point(12, 262);
            lbl_fullname.Name = "lbl_fullname";
            lbl_fullname.Size = new Size(110, 25);
            lbl_fullname.TabIndex = 1;
            lbl_fullname.Text = "Full Name :";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_phone.Location = new Point(12, 324);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(76, 25);
            lbl_phone.TabIndex = 2;
            lbl_phone.Text = "Phone :";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_email.Location = new Point(12, 388);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(69, 25);
            lbl_email.TabIndex = 3;
            lbl_email.Text = "Email :";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_address.Location = new Point(228, 314);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(90, 25);
            lbl_address.TabIndex = 4;
            lbl_address.Text = "Address :";
            // 
            // lbl_id_card_number
            // 
            lbl_id_card_number.AutoSize = true;
            lbl_id_card_number.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_id_card_number.Location = new Point(228, 260);
            lbl_id_card_number.Name = "lbl_id_card_number";
            lbl_id_card_number.Size = new Size(138, 25);
            lbl_id_card_number.TabIndex = 5;
            lbl_id_card_number.Text = "Card Number :";
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(12, 288);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(182, 23);
            txt_fullname.TabIndex = 6;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(12, 352);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(182, 23);
            txt_phone.TabIndex = 7;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(12, 416);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(182, 23);
            txt_email.TabIndex = 8;
            // 
            // txt_cardnumber
            // 
            txt_cardnumber.Location = new Point(228, 288);
            txt_cardnumber.Name = "txt_cardnumber";
            txt_cardnumber.Size = new Size(205, 23);
            txt_cardnumber.TabIndex = 9;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(228, 340);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(268, 97);
            txt_address.TabIndex = 10;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Location = new Point(527, 388);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(186, 48);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete Guest";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(529, 345);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(186, 39);
            btn_edit.TabIndex = 13;
            btn_edit.Text = "Edit Guest";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(527, 300);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(186, 39);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add Guest";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // lbl_guest_id
            // 
            lbl_guest_id.AutoSize = true;
            lbl_guest_id.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_guest_id.Location = new Point(527, 262);
            lbl_guest_id.Name = "lbl_guest_id";
            lbl_guest_id.Size = new Size(96, 25);
            lbl_guest_id.TabIndex = 15;
            lbl_guest_id.Text = "Guest ID :";
            // 
            // lbl_guestid_value
            // 
            lbl_guestid_value.AutoSize = true;
            lbl_guestid_value.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_guestid_value.Location = new Point(629, 262);
            lbl_guestid_value.Name = "lbl_guestid_value";
            lbl_guestid_value.Size = new Size(23, 25);
            lbl_guestid_value.TabIndex = 16;
            lbl_guestid_value.Text = "0";
            // 
            // GuestPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
            Controls.Add(lbl_guestid_value);
            Controls.Add(lbl_guest_id);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(txt_address);
            Controls.Add(txt_cardnumber);
            Controls.Add(txt_email);
            Controls.Add(txt_phone);
            Controls.Add(txt_fullname);
            Controls.Add(lbl_id_card_number);
            Controls.Add(lbl_address);
            Controls.Add(lbl_email);
            Controls.Add(lbl_phone);
            Controls.Add(lbl_fullname);
            Controls.Add(dataGridView1);
            Name = "GuestPage";
            Text = "GuestPage";
            Load += GuestPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_fullname;
        private Label lbl_phone;
        private Label lbl_email;
        private Label lbl_address;
        private Label lbl_id_card_number;
        private TextBox txt_fullname;
        private TextBox txt_phone;
        private TextBox txt_email;
        private TextBox txt_cardnumber;
        private TextBox txt_address;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private Label lbl_guest_id;
        private Label lbl_guestid_value;
    }
}