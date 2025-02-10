namespace HotelBookingApp
{
    public partial class Home : Form
    {
        private string UserRole = "guest";
        public Home(string role)
        {
            InitializeComponent();
            UserRole = role;
            RoleBasedAccess();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            HideButton();
            RoleBasedAccess();
            btn_exit.Visible = true;
        }

        void RoleBasedAccess()
        {
            switch (UserRole)
            {
                case "admin":
                    lbl_WelcomeRole.Visible = true;
                    lbl_WelcomeRole.Text = "Logged in as " + UserRole;
                    lbl_Welcome.Visible = false;
                    ShowButtonVisible();
                    ExitOFF();
                    ShowButtonAdmin();
                    btn_Login.Visible = false;
                    break;
                case "receptionist":
                    lbl_WelcomeRole.Visible = true;
                    lbl_WelcomeRole.Text = "Logged in as " + UserRole;
                    lbl_Welcome.Visible = false;
                    ShowButtonVisible();
                    ShowButtonReceptionist();
                    ExitOFF();
                    btn_Login.Visible = false;
                    break;
                case "manager":
                    lbl_WelcomeRole.Visible = true;
                    lbl_WelcomeRole.Text = "Logged in as " + UserRole;
                    lbl_Welcome.Visible = false;
                    ShowButtonVisible();
                    ExitOFF();
                    ShowButtonManager();
                    btn_Login.Visible = false;
                    break;
                default:
                    lbl_WelcomeRole.Visible = false;
                    lbl_Welcome.Visible = true;
                    btn_Login.Visible = true;
                    btn_out.Visible = false;
                    HideButton();
                    break;
            }
        }

        void ExitOFF()
        {
            btn_exit.Visible = false;
        }

        void HideButton()
        {
            btn_userpage.Visible = false;
            btn_guestpage.Visible = false;
            btn_report.Visible = false;
            btn_reservation.Visible = false;
            btn_roompage.Visible = false;
            lbl_WelcomeRole.Visible = false;
            btn_out.Visible = false;
        }

        void ShowButtonVisible()
        {
            btn_out.Visible = true;
            btn_userpage.Visible = true;
            btn_guestpage.Visible = true;
            btn_report.Visible = true;
            btn_reservation.Visible = true;
            btn_roompage.Visible = true;
        }

        void ShowButtonAdmin()
        {
            btn_userpage.Enabled = true;
            btn_guestpage.Enabled = true;
            btn_report.Enabled = true;
            btn_reservation.Enabled = true;
            btn_roompage.Enabled = true;
        }

        void ShowButtonReceptionist()
        {
            btn_userpage.Enabled = false;
            btn_guestpage.Enabled = true;
            btn_report.Enabled = false;
            btn_reservation.Enabled = true;
            btn_roompage.Enabled = false;
        }

        void ShowButtonManager()
        {
            btn_userpage.Enabled = false;
            btn_guestpage.Enabled = true;
            btn_report.Enabled = true;
            btn_reservation.Enabled = true;
            btn_roompage.Enabled = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (!string.IsNullOrEmpty(login.UserRole))
            {
                UserRole = login.UserRole;
                RoleBasedAccess();
            }
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

        private void btn_report_Click(object sender, EventArgs e)
        {
            ReportPage reportPage = new ReportPage();
            reportPage.ShowDialog();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Logout();
        }

        void Logout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserRole = "guest";
                RoleBasedAccess();
                btn_exit.Visible = true;
                MessageBox.Show("You have been logged out.", "Logout Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
