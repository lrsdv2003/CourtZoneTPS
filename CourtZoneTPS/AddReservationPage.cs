using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtZoneTPS
{
    public partial class AddReservationPage : UserControl
    {
        public AddReservationPage()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCustomerName.Clear();
            textBoxContactNumber.Clear();
            comboBoxCourtType.ResetText();
            comboBoxPaymentStatus.ResetText();
            comboBoxSportType.ResetText();
            comboBoxTime.ResetText();
            dateTimePickerDate.ResetText();
        }
    }
}
