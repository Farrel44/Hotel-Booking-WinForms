namespace HotelBookingApp
{
    partial class RoomPage
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
            lbl_roomnum = new Label();
            lbl_type = new Label();
            lbl_price = new Label();
            lbl_status = new Label();
            txt_roomnumber = new TextBox();
            txt_roomprice = new TextBox();
            cmbroomtype = new ComboBox();
            cmbstatus = new ComboBox();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            lbl_roomid = new Label();
            lbl_roomidvalue = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(566, 465);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbl_roomnum
            // 
            lbl_roomnum.AutoSize = true;
            lbl_roomnum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_roomnum.Location = new Point(601, 56);
            lbl_roomnum.Name = "lbl_roomnum";
            lbl_roomnum.Size = new Size(126, 21);
            lbl_roomnum.TabIndex = 1;
            lbl_roomnum.Text = "Room Number :";
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_type.Location = new Point(601, 115);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new Size(101, 21);
            lbl_type.TabIndex = 2;
            lbl_type.Text = "Room Type :";
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_price.Location = new Point(601, 175);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(102, 21);
            lbl_price.TabIndex = 3;
            lbl_price.Text = "Room Price :";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_status.Location = new Point(601, 238);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(111, 21);
            lbl_status.TabIndex = 4;
            lbl_status.Text = "Room Status :";
            // 
            // txt_roomnumber
            // 
            txt_roomnumber.Location = new Point(601, 80);
            txt_roomnumber.Name = "txt_roomnumber";
            txt_roomnumber.Size = new Size(170, 23);
            txt_roomnumber.TabIndex = 5;
            // 
            // txt_roomprice
            // 
            txt_roomprice.Location = new Point(603, 199);
            txt_roomprice.Name = "txt_roomprice";
            txt_roomprice.Size = new Size(100, 23);
            txt_roomprice.TabIndex = 6;
            // 
            // cmbroomtype
            // 
            cmbroomtype.FormattingEnabled = true;
            cmbroomtype.Location = new Point(603, 139);
            cmbroomtype.Name = "cmbroomtype";
            cmbroomtype.Size = new Size(121, 23);
            cmbroomtype.TabIndex = 7;
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Location = new Point(603, 262);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(121, 23);
            cmbstatus.TabIndex = 8;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(601, 320);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(186, 39);
            btn_add.TabIndex = 9;
            btn_add.Text = "Add Room";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(603, 365);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(186, 39);
            btn_edit.TabIndex = 10;
            btn_edit.Text = "Edit Room";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Location = new Point(603, 438);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(186, 39);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "Delete Room";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // lbl_roomid
            // 
            lbl_roomid.AutoSize = true;
            lbl_roomid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_roomid.Location = new Point(601, 12);
            lbl_roomid.Name = "lbl_roomid";
            lbl_roomid.Size = new Size(82, 21);
            lbl_roomid.TabIndex = 12;
            lbl_roomid.Text = "Room ID :";
            // 
            // lbl_roomidvalue
            // 
            lbl_roomidvalue.AutoSize = true;
            lbl_roomidvalue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_roomidvalue.Location = new Point(689, 12);
            lbl_roomidvalue.Name = "lbl_roomidvalue";
            lbl_roomidvalue.Size = new Size(19, 21);
            lbl_roomidvalue.TabIndex = 13;
            lbl_roomidvalue.Text = "0";
            // 
            // RoomPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(lbl_roomidvalue);
            Controls.Add(lbl_roomid);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(cmbstatus);
            Controls.Add(cmbroomtype);
            Controls.Add(txt_roomprice);
            Controls.Add(txt_roomnumber);
            Controls.Add(lbl_status);
            Controls.Add(lbl_price);
            Controls.Add(lbl_type);
            Controls.Add(lbl_roomnum);
            Controls.Add(dataGridView1);
            Name = "RoomPage";
            Text = "RoomPage";
            Load += RoomPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_roomnum;
        private Label lbl_type;
        private Label lbl_price;
        private Label lbl_status;
        private TextBox txt_roomnumber;
        private TextBox txt_roomprice;
        private ComboBox cmbroomtype;
        private ComboBox cmbstatus;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private Label lbl_roomid;
        private Label lbl_roomidvalue;
    }
}