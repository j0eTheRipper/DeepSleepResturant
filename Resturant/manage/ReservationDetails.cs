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
            TextBox txtHour = (TextBox)sender;
            int input;
            int.TryParse(txtHour.Text, out input);
            if ((input == 0 || input > 12) && txtHour.ForeColor != Color.Gray)
                txtHour.Text = "";
        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {
            TextBox txtMinute = (TextBox)sender;
            int input;
            int.TryParse(txtMinute.Text, out input);
            if ((input == 0 || input > 59) && txtMinute.ForeColor != Color.Gray && txtMinute.Text != "0" && txtMinute.Text != "00")
                txtMinute.Text = "";
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

        public void loadReservationData(int ReservationID)
        {
            Reservation reservation = new Reservation(ReservationID);
            if (reservation.ID == 0)
            {
                MessageBox.Show("please enter a valid reservationID from the table below.");
                return;
            } 
            txtNumberOfPeople.Text = reservation.NumberOfPeople.ToString();
            dntDate.Value = DateTime.Parse(reservation.Date);
            AMPMFormat(reservation.InTime, btnAMPMFrom, txtHourFrom, txtMinuteFrom);
            AMPMFormat(reservation.OutTime, btnAMPMTo, txtHourTo, txtMinuteTo);
        }

        private void AMPMFormat(string time, Button btnAMPM, TextBox txtHour, TextBox txtMinute)
        {
            string[] hourMinute = time.Split(':');
            int.TryParse(hourMinute[0], out int hour);
            txtHour.ForeColor = Color.Black;
            txtMinute.ForeColor = Color.Black;
            if (hour == 0)
                txtHour.Text = "12";
            else if (hour >= 12)
            {
                if (btnAMPM.Text == "AM")
                    btnAMPM_Click(btnAMPM, new EventArgs());
                txtHour.Text = hour > 12 ? (hour - 12).ToString() : "12";
            } else
                txtHour.Text = hourMinute[0];
            txtMinute.Text = hourMinute[1];
        }

        public void ClearData()
        {
            txtNumberOfPeople.Text = "";
            txtHourFrom.Text = "";
            txtHourTo.Text = "";
            txtMinuteTo.Text = "";
            txtMinuteFrom.Text = "";
            txtBoxLeave(txtMinuteFrom, new EventArgs());
            txtBoxLeave(txtHourFrom, new EventArgs());
            txtBoxLeave(txtHourTo, new EventArgs());
            txtBoxLeave(txtMinuteTo, new EventArgs());
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
