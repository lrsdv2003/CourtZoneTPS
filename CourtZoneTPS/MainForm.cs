namespace CourtZoneTPS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
