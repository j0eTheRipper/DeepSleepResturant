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
                textBox.Text = textBox.Name.StartsWith("txtHour") ? "HH" : "MM";
            }
        }

        private void txtHour_TextChanged_1(object sender, EventArgs e)
        {
            int input;
            TextBox hour = (TextBox)sender;
            int.TryParse(hour.Text, out input);
            if ((input == 0 || input > 12) && hour.ForeColor != Color.Gray)
                txtHourIn.Text = "";
        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {
            int input;
            int.TryParse(txtMinuteIn.Text, out input);
            TextBox minute = (TextBox)sender;
            if ((input == 0 || input > 59) && txtMinuteIn.ForeColor != Color.Gray && minute.Text != "0")
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
            string timeIn = Get24HourFormat(txtHourIn, txtMinuteIn, btnAMPMIn);
            string timeOut = Get24HourFormat(txtHourOut, txtMinuteOut, btnAMPMOut);
            int.TryParse(txtNumberOfPeople.Text, out int numberOfPeople);

            string query = "SELECT * FROM reservations ";
            string whereClause = "WHERE ";
            if (chbxIncludeDate.Checked)
                whereClause += $"reservationDate >= '{date}' and ";
            if (timeIn != null)
                whereClause += $"reservationStartTime >= '{timeIn}' and ";
            if (timeOut != null)
                whereClause += $"reservationEndTime <= '{timeOut}' and ";
            if (numberOfPeople != 0)
                whereClause += $"tableID in (select tableID from Tables where numberOfSeats >= {numberOfPeople});";
            else
                whereClause += "reservationID is not null;";

            query += whereClause;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReservations.DataSource = dt;
            }
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
    }
}
