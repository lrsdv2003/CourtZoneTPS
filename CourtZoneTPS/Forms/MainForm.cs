using System;
using System.Windows.Forms;
using CourtZoneTPS.Services;

namespace CourtZoneTPS
{
    public partial class MainForm : Form
    {
        private int currentUserId = UserHelper.CurrentUserId;

        public MainForm()
        {
            InitializeComponent();
            CurrentUser();
            LoadPage(new DashboardForm());
        }

        public void LoadPage(UserControl page)
        {
            panelContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            LoadPage(new DashboardForm());
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            AddReservationForm form = new AddReservationForm(currentUserId);

            form.OnReservationAdded = () =>
            {
                LoadPage(new DashboardForm());
            };

            LoadPage(form);
        }

        private void buttonEditReservation_Click(object sender, EventArgs e)
        {
            LoadPage(new EditReservationForm());
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            LoadPage(new ReportsPage());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }


        private void CurrentUser()
        {
            string username = UserHelper.CurrentEmployeeNumber;

            if (string.IsNullOrEmpty(username))
                buttonLogout.Text = "User (Unknown)";
            else
                buttonLogout.Text = $"User ({username})";
        }

    }
}
