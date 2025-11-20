using System.Data.SQLite;

namespace CourtZoneTPS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CurrentUser();
            LoadPage(new DashboardPage());
        }
        public void LoadPage(UserControl page)
        {
            panelContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            LoadPage(new DashboardPage());
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            LoadPage(new AddReservationPage());
        }

        private void buttonEditReservation_Click(object sender, EventArgs e)
        {
            LoadPage(new EditReservationPage());
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            LoadPage(new ReportsPage());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Close();

        }
        private void CurrentUser()
        {
            buttonLogout.Text = "User (" + UserHelper.CurrentUsername + ")";
            LoadPage(new DashboardPage());
        }
    }
}

