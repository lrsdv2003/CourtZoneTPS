using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourtZoneTPS
{
    public partial class DashboardPage : UserControl
    {

        public DashboardPage()
        {
            InitializeComponent();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDashboardDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy | hh:mm tt");
        }
    }
}