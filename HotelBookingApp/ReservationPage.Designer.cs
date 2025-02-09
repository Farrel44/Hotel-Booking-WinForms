namespace HotelBookingApp
{
    partial class ReservationPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            btn_book = new Button();
            btn_checkIn = new Button();
            btn_checkOut = new Button();
            btn_cancelReservation = new Button();
            txt_guestId = new TextBox();
            txt_roomId = new TextBox();
            txt_reservationId = new TextBox();
            txt_amount = new TextBox();
            cmbPaymentMethod = new ComboBox();
            cmbStatus = new ComboBox();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            Label lblGuestId = new Label();
            Label lblRoomId = new Label();
            Label lblReservationId = new Label();
            Label lblAmount = new Label();
            Label lblPaymentMethod = new Label();
            Label lblCheckIn = new Label();
            Label lblCheckOut = new Label();
            Label lblStatus = new Label();
            SuspendLayout();

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(804, 250);
            dataGridView1.TabIndex = 0;

            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 270);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(804, 150);
            dataGridView2.TabIndex = 1;

            lblGuestId.Text = "Guest ID:";
            lblGuestId.Location = new Point(850, 20);
            txt_guestId.Location = new Point(950, 20);
            txt_guestId.Size = new Size(150, 22);

            lblRoomId.Text = "Room ID:";
            lblRoomId.Location = new Point(850, 60);
            txt_roomId.Location = new Point(950, 60);
            txt_roomId.Size = new Size(150, 22);

            lblReservationId.Text = "Reservation ID:";
            lblReservationId.Location = new Point(850, 100);
            txt_reservationId.Location = new Point(950, 100);
            txt_reservationId.Size = new Size(150, 22);

            lblCheckIn.Text = "Check-In Date:";
            lblCheckIn.Location = new Point(850, 140);
            dtpCheckIn.Location = new Point(950, 140);
            dtpCheckIn.Size = new Size(150, 22);

            lblCheckOut.Text = "Check-Out Date:";
            lblCheckOut.Location = new Point(850, 180);
            dtpCheckOut.Location = new Point(950, 180);
            dtpCheckOut.Size = new Size(150, 22);

            lblAmount.Text = "Amount:";
            lblAmount.Location = new Point(850, 220);
            txt_amount.Location = new Point(950, 220);
            txt_amount.Size = new Size(150, 22);

            lblPaymentMethod.Text = "Payment Method:";
            lblPaymentMethod.Location = new Point(850, 260);
            cmbPaymentMethod.Location = new Point(950, 260);
            cmbPaymentMethod.Size = new Size(150, 22);

            lblStatus.Text = "Status:";
            lblStatus.Location = new Point(850, 300);
            cmbStatus.Location = new Point(950, 300);
            cmbStatus.Size = new Size(150, 22);

            btn_book.Location = new Point(850, 360);
            btn_book.Name = "btn_book";
            btn_book.Size = new Size(136, 30);
            btn_book.TabIndex = 2;
            btn_book.Text = "Book Reservation";
            btn_book.UseVisualStyleBackColor = true;

            btn_checkIn.Location = new Point(850, 400);
            btn_checkIn.Name = "btn_checkIn";
            btn_checkIn.Size = new Size(136, 30);
            btn_checkIn.TabIndex = 3;
            btn_checkIn.Text = "Check In";
            btn_checkIn.UseVisualStyleBackColor = true;

            btn_checkOut.Location = new Point(850, 440);
            btn_checkOut.Name = "btn_checkOut";
            btn_checkOut.Size = new Size(136, 30);
            btn_checkOut.TabIndex = 4;
            btn_checkOut.Text = "Check Out";
            btn_checkOut.UseVisualStyleBackColor = true;

            btn_cancelReservation.Location = new Point(850, 480);
            btn_cancelReservation.Name = "btn_cancelReservation";
            btn_cancelReservation.Size = new Size(136, 30);
            btn_cancelReservation.TabIndex = 5;
            btn_cancelReservation.Text = "Cancel Reservation";
            btn_cancelReservation.UseVisualStyleBackColor = true;

            ClientSize = new Size(1120, 550);
            Controls.Add(lblGuestId);
            Controls.Add(txt_guestId);
            Controls.Add(lblRoomId);
            Controls.Add(txt_roomId);
            Controls.Add(lblReservationId);
            Controls.Add(txt_reservationId);
            Controls.Add(lblCheckIn);
            Controls.Add(dtpCheckIn);
            Controls.Add(lblCheckOut);
            Controls.Add(dtpCheckOut);
            Controls.Add(lblAmount);
            Controls.Add(txt_amount);
            Controls.Add(lblPaymentMethod);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btn_cancelReservation);
            Controls.Add(btn_checkOut);
            Controls.Add(btn_checkIn);
            Controls.Add(btn_book);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "ReservationPage";
            Text = "Reservation Page";
            Load += ReservationPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btn_book;
        private Button btn_checkIn;
        private Button btn_checkOut;
        private Button btn_cancelReservation;
        private TextBox txt_guestId;
        private TextBox txt_roomId;
        private TextBox txt_reservationId;
        private TextBox txt_amount;
        private ComboBox cmbPaymentMethod;
        private ComboBox cmbStatus;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
    }
}
