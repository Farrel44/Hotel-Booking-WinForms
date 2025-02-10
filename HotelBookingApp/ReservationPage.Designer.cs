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
            dataGridViewReservations = new DataGridView();
            dataGridViewRooms = new DataGridView();
            dataGridViewGuests = new DataGridView();
            btn_book = new Button();
            btn_processPayment = new Button();
            btn_cancelReservation = new Button();
            txt_guestId = new TextBox();
            txt_roomId = new TextBox();
            txt_reservationId = new TextBox();
            txt_amount = new TextBox();
            cmbPaymentMethod = new ComboBox();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            lblGuestId = new Label();
            lblRoomId = new Label();
            lblReservationId = new Label();
            lblAmount = new Label();
            lblPaymentMethod = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            btn_update = new Button();
            lbl_reservation_status = new Label();
            cmbStatus = new ComboBox();
            btn_updateStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReservations
            // 
            dataGridViewReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservations.Location = new Point(12, 12);
            dataGridViewReservations.Name = "dataGridViewReservations";
            dataGridViewReservations.Size = new Size(804, 271);
            dataGridViewReservations.TabIndex = 0;
            dataGridViewReservations.CellContentClick += dataGridViewReservations_CellContentClick;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new Point(10, 298);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.Size = new Size(400, 182);
            dataGridViewRooms.TabIndex = 1;
            dataGridViewRooms.CellContentClick += dataGridViewRooms_CellContentClick;
            // 
            // dataGridViewGuests
            // 
            dataGridViewGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGuests.Location = new Point(416, 298);
            dataGridViewGuests.Name = "dataGridViewGuests";
            dataGridViewGuests.Size = new Size(400, 182);
            dataGridViewGuests.TabIndex = 2;
            dataGridViewGuests.CellContentClick += dataGridViewGuests_CellContentClick;
            // 
            // btn_book
            // 
            btn_book.Location = new Point(850, 300);
            btn_book.Name = "btn_book";
            btn_book.Size = new Size(258, 30);
            btn_book.TabIndex = 16;
            btn_book.Text = "Book Reservation";
            btn_book.UseVisualStyleBackColor = true;
            btn_book.Click += btn_book_Click_1;
            // 
            // btn_processPayment
            // 
            btn_processPayment.Location = new Point(850, 372);
            btn_processPayment.Name = "btn_processPayment";
            btn_processPayment.Size = new Size(258, 30);
            btn_processPayment.TabIndex = 15;
            btn_processPayment.Text = "Process Payment";
            btn_processPayment.UseVisualStyleBackColor = true;
            btn_processPayment.Click += btn_processPayment_Click_1;
            // 
            // btn_cancelReservation
            // 
            btn_cancelReservation.Location = new Point(850, 412);
            btn_cancelReservation.Name = "btn_cancelReservation";
            btn_cancelReservation.Size = new Size(258, 30);
            btn_cancelReservation.TabIndex = 14;
            btn_cancelReservation.Text = "Cancel Reservation";
            btn_cancelReservation.UseVisualStyleBackColor = true;
            btn_cancelReservation.Click += btn_cancelReservation_Click_1;
            // 
            // txt_guestId
            // 
            txt_guestId.Location = new Point(950, 20);
            txt_guestId.Name = "txt_guestId";
            txt_guestId.Size = new Size(150, 23);
            txt_guestId.TabIndex = 1;
            // 
            // txt_roomId
            // 
            txt_roomId.Location = new Point(950, 60);
            txt_roomId.Name = "txt_roomId";
            txt_roomId.Size = new Size(150, 23);
            txt_roomId.TabIndex = 3;
            // 
            // txt_reservationId
            // 
            txt_reservationId.Location = new Point(950, 100);
            txt_reservationId.Name = "txt_reservationId";
            txt_reservationId.Size = new Size(150, 23);
            txt_reservationId.TabIndex = 5;
            // 
            // txt_amount
            // 
            txt_amount.Location = new Point(950, 220);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(150, 23);
            txt_amount.TabIndex = 11;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Location = new Point(950, 260);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(150, 23);
            cmbPaymentMethod.TabIndex = 13;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(950, 140);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(150, 23);
            dtpCheckIn.TabIndex = 7;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(950, 180);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(150, 23);
            dtpCheckOut.TabIndex = 9;
            // 
            // lblGuestId
            // 
            lblGuestId.Location = new Point(850, 20);
            lblGuestId.Name = "lblGuestId";
            lblGuestId.Size = new Size(100, 23);
            lblGuestId.TabIndex = 0;
            lblGuestId.Text = "Guest ID:";
            // 
            // lblRoomId
            // 
            lblRoomId.Location = new Point(850, 60);
            lblRoomId.Name = "lblRoomId";
            lblRoomId.Size = new Size(100, 23);
            lblRoomId.TabIndex = 2;
            lblRoomId.Text = "Room ID:";
            // 
            // lblReservationId
            // 
            lblReservationId.Location = new Point(850, 100);
            lblReservationId.Name = "lblReservationId";
            lblReservationId.Size = new Size(100, 23);
            lblReservationId.TabIndex = 4;
            lblReservationId.Text = "Reservation ID:";
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(850, 220);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(100, 23);
            lblAmount.TabIndex = 10;
            lblAmount.Text = "Amount:";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.Location = new Point(850, 260);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(100, 23);
            lblPaymentMethod.TabIndex = 12;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblCheckIn
            // 
            lblCheckIn.Location = new Point(850, 140);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(100, 23);
            lblCheckIn.TabIndex = 6;
            lblCheckIn.Text = "Check-In Date:";
            // 
            // lblCheckOut
            // 
            lblCheckOut.Location = new Point(850, 180);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(100, 23);
            lblCheckOut.TabIndex = 8;
            lblCheckOut.Text = "Check-Out Date:";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(850, 336);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(258, 30);
            btn_update.TabIndex = 17;
            btn_update.Text = "Update Reservation";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // lbl_reservation_status
            // 
            lbl_reservation_status.Location = new Point(850, 457);
            lbl_reservation_status.Name = "lbl_reservation_status";
            lbl_reservation_status.Size = new Size(177, 23);
            lbl_reservation_status.TabIndex = 18;
            lbl_reservation_status.Text = "Update Reservation Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(850, 483);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 23);
            cmbStatus.TabIndex = 19;
            // 
            // btn_updateStatus
            // 
            btn_updateStatus.Location = new Point(850, 512);
            btn_updateStatus.Name = "btn_updateStatus";
            btn_updateStatus.Size = new Size(258, 30);
            btn_updateStatus.TabIndex = 20;
            btn_updateStatus.Text = "Update Reservation Status";
            btn_updateStatus.UseVisualStyleBackColor = true;
            btn_updateStatus.Click += btn_updateStatus_Click;
            // 
            // ReservationPage
            // 
            ClientSize = new Size(1131, 553);
            Controls.Add(btn_updateStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lbl_reservation_status);
            Controls.Add(btn_update);
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
            Controls.Add(btn_cancelReservation);
            Controls.Add(btn_processPayment);
            Controls.Add(btn_book);
            Controls.Add(dataGridViewGuests);
            Controls.Add(dataGridViewRooms);
            Controls.Add(dataGridViewReservations);
            Name = "ReservationPage";
            Text = "Reservation Page";
            Load += ReservationPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReservations;
        private DataGridView dataGridViewRooms;
        private DataGridView dataGridViewGuests;
        private Button btn_book;
        private Button btn_processPayment;
        private Button btn_cancelReservation;
        private TextBox txt_guestId;
        private TextBox txt_roomId;
        private TextBox txt_reservationId;
        private TextBox txt_amount;
        private ComboBox cmbPaymentMethod;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private Label lblGuestId;
        private Label lblRoomId;
        private Label lblReservationId;
        private Label lblAmount;
        private Label lblPaymentMethod;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private Button btn_update;
        private Label lbl_reservation_status;
        private ComboBox cmbStatus;
        private Button btn_updateStatus;
    }
}
