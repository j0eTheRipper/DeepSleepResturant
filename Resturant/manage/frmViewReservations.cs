using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.manage
{
    public partial class frmViewReservations : Form
    {
        public frmViewReservations()
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
                textBox.Text = textBox.Name == "txtHour" ? "HH" : "MM";
            }
        }

        private void txtHour_TextChanged_1(object sender, EventArgs e)
        {
            int input;
            int.TryParse(txtHourIn.Text, out input);
            if ((input == 0 || input > 12) && txtHourIn.ForeColor != Color.Gray)
                txtHourIn.Text = "";
        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {
            int input;
            int.TryParse(txtMinuteIn.Text, out input);
            if ((input == 0 || input > 59) && txtMinuteIn.ForeColor != Color.Gray)
                txtMinuteIn.Text = "";
        }

        private void btnAMPM_Click(object sender, EventArgs e)
        {
            if (btnAMPMIn.Text == "AM")
            {
                btnAMPMIn.Text = "PM";
                btnAMPMIn.BackColor = Color.MidnightBlue;
                btnAMPMIn.ForeColor = Color.White;
            }
            else
            {
                btnAMPMIn.Text = "AM";
                btnAMPMIn.BackColor = Color.Yellow;
                btnAMPMIn.ForeColor = Color.Black;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string date = dntDate.Value.ToString("yyyy-MM-dd");
            string timeIn = Get24HourFormat(txtHourIn, txtMinuteIn);
            string timeOut = Get24HourFormat(txtHourOut, txtMinuteOut);
            int.TryParse(txtNumberOfPeople.Text, out int numberOfPeople);

            string query = "SELECT * FROM reservations ";
            string whereClause = "WHERE ";
            if (chbxIncludeDate.Checked)
                whereClause += $"date = '{date}' and ";
            if (timeIn != null)
                whereClause += $"time = '{timeIn}' and ";
            if (timeOut != null)
                whereClause += $"timeOut = '{timeOut}' and ";
            if (numberOfPeople != 0)
                whereClause += $"tableID in (select tableID from Tables where numberOfSeats >= {numberOfPeople});";
            else
                whereClause += "reservationID is not null;";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM reservations;", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReservations.DataSource = dt;
            }
        }

        private string Get24HourFormat(TextBox txtHour, TextBox txtMinute)
        {
            if (txtHour.Text != "HH" && txtMinute.Text != "MM")
            {
                int.TryParse(txtHour.Text, out int hour);
                if (btnAMPMIn.Text == "PM" && hour != 12)
                    hour += 12;
                if (hour == 24)
                    hour = 0;

                return $"{hour}:{txtMinuteIn.Text}";
            }
            return null;
        }
    }
}
