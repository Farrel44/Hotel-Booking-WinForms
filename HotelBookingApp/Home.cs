namespace HotelBookingApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            HideButton();
        }

        void HideButton()
        {
            btn_userpage.Visible = false;
        }

        void ShowButton()
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void btn_UserPage_Click(object sender, EventArgs e)
        {
            UserPage userPage = new UserPage();
            userPage.ShowDialog();
        }

        private void btn_roompage_Click(object sender, EventArgs e)
        {
            RoomPage roompage = new RoomPage();
            roompage.ShowDialog();
        }

        private void btn_guestpage_Click(object sender, EventArgs e)
        {
            GuestPage guestPage = new GuestPage();
            guestPage.ShowDialog();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            ReservationPage reservationPage = new ReservationPage();
            reservationPage.ShowDialog();
        }
    }
}
