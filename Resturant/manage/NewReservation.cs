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

namespace Resturant
{
    public partial class NewReservation : Form
    {
        private List<int> customerIDs = new List<int>();
        public NewReservation()
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

        private void btnAMPM_Click(object sender, EventArgs e)
        {
            if (btnAMPMFrom.Text == "AM")
            {
                btnAMPMFrom.Text = "PM";
                btnAMPMFrom.BackColor = Color.MidnightBlue;
                btnAMPMFrom.ForeColor = Color.White;
            } else
            {
                btnAMPMFrom.Text = "AM";
                btnAMPMFrom.BackColor = Color.Yellow;
                btnAMPMFrom.ForeColor = Color.Black;
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

        private void NewReservation_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("SELECT CustomerID, username FROM Customer WHERE reservation is null;", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstCustomers.Items.Add(reader.GetString(1));
                    customerIDs.Add(reader.GetInt32(0));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dntDate.Value.ToString("yyyy-MM-dd");
            string inTime = Get24HourFormat(txtHourFrom, txtMinuteFrom, btnAMPMFrom);
            string outTime = Get24HourFormat(txtHourTo, txtMinuteTo, btnAMPMTo);
            object username = lstCustomers.SelectedItem;
            int numberOfPeople;
            int.TryParse(txtNumberOfPeople.Text, out numberOfPeople);

            if (inTime == null || outTime == null || username == null || numberOfPeople == 0)
                MessageBox.Show("please select a customer and specify a date and time");
            else
            {
                if (btnAMPMFrom.Text == "PM" && txtHourFrom.Text != "12")
                {
                    int hour = int.Parse(txtHourFrom.Text) + 12;
                    inTime = $"{hour}:{txtMinuteFrom.Text}";
                }
                if (btnAMPMFrom.Text == "AM" && txtHourFrom.Text == "12")
                    inTime = $"0:{txtMinuteFrom.Text}";

                Reservation reservation = new Reservation(customerIDs[lstCustomers.SelectedIndex], numberOfPeople, date, inTime, outTime);
                Table table = reservation.SearchForTable();
                if (table != null)
                {
                    reservation.UpdateReservationsTable(table);
                    bool isSuccess = reservation.UpdateCustomersTable();
                    lstCustomers.Items.Remove(lstCustomers.SelectedItem);
                    if (isSuccess)
                        MessageBox.Show($"Successfully reserved table {table.TableID} for {username}. Reservation will be at {date}, {inTime}.");
                    else
                        MessageBox.Show("Something went wrong!!");
                }
                else
                {
                    MessageBox.Show("There is no available table at the moment or the number of people is too high to accomodate.");
                }
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
