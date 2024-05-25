using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.manage
{
    public partial class ReservationDetails : UserControl
    {
        public ReservationDetails()
        {
            InitializeComponent();
        }

        private void txtBoxEnter(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.ForeColor == Color.Gray)
            {
                txtBox.ForeColor = Color.Black;
                txtBox.Text = "";
            }
        }

        private void txtBoxLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "")
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = textBox.Name.StartsWith("txtHour") ? "HH" : "MM";
            }
        }

        private void btnAMPM_Click(object sender, EventArgs e)
        {
            Button btnAMPM = (Button)sender;
            if (btnAMPM.Text == "AM")
            {
                btnAMPM.Text = "PM";
                btnAMPM.BackColor = Color.MidnightBlue;
                btnAMPM.ForeColor = Color.White;
            }
            else
            {
                btnAMPM.Text = "AM";
                btnAMPM.BackColor = Color.Yellow;
                btnAMPM.ForeColor = Color.Black;
            }
        }

        private void txtHour_TextChanged_1(object sender, EventArgs e)
        {
            int input;
            int.TryParse(txtHourFrom.Text, out input);
            if ((input == 0 || input > 12) && txtHourFrom.ForeColor != Color.Gray)
                txtHourFrom.Text = "";
        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {
            int input;
            int.TryParse(txtMinuteFrom.Text, out input);
            if ((input == 0 || input > 59) && txtMinuteFrom.ForeColor != Color.Gray)
                txtMinuteFrom.Text = "";
        }

        private string Get24HourFormat(TextBox txtHour, TextBox txtMinute, Button btnAMPM)
        {
            if (txtHour.Text != "HH" && txtMinute.Text != "MM")
            {
                int.TryParse(txtHour.Text, out int hour);
                if (btnAMPM.Text == "PM" && hour != 12)
                    hour += 12;
                if (btnAMPM.Text == "AM" && hour == 12)
                    hour = 0;
                return $"{hour}:{txtMinute.Text}";
            }
            return null;
        }

        public string Date
        {
            get
            {
                return dntDate.Value.ToString("yyyy-MM-dd");
            }
        }

        public string StartTime
        {
            get
            {
                return Get24HourFormat(txtHourFrom, txtMinuteFrom, btnAMPMFrom);
            }
        }

        public string EndTime
        {
            get
            {
                return Get24HourFormat(txtHourTo, txtMinuteTo, btnAMPMTo);
            }
        }

        public int NumberOfPeople
        {
            get
            {
                int.TryParse(txtNumberOfPeople.Text, out int numberOfPeople);
                return numberOfPeople;
            }
        }
    }
}
