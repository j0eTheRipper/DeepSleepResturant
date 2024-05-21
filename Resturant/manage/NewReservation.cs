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
            if (btnAMPM.Text == "AM")
            {
                btnAMPM.Text = "PM";
                btnAMPM.BackColor = Color.MidnightBlue;
                btnAMPM.ForeColor = Color.White;
            } else
            {
                btnAMPM.Text = "AM";
                btnAMPM.BackColor = Color.Yellow;
                btnAMPM.ForeColor = Color.Black;
            }
        }

        private void txtHour_TextChanged_1(object sender, EventArgs e)
        {
            int input;
            int.TryParse(txtHour.Text, out input);
            if ((input == 0 || input > 12) && txtHour.ForeColor != Color.Gray)
                txtHour.Text = "";
        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {
            int input;
            int.TryParse(txtMinute.Text, out input);
            if ((input == 0 || input > 59) && txtMinute.ForeColor != Color.Gray)
                txtMinute.Text = "";
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
            string time = $"{txtHour.Text}:{txtMinute.Text}";
            object username = lstCustomers.SelectedItem;
            int numberOfPeople;
            int.TryParse(txtNumberOfPeople.Text, out numberOfPeople);

            if (time == "HH:MM" || username == null || numberOfPeople == 0)
                MessageBox.Show("please select a customer and specify a date and time");
            else
            {
                if (btnAMPM.Text == "PM" && txtHour.Text != "12")
                {
                    int hour = int.Parse(txtHour.Text) + 12;
                    time = $"{hour}:{txtMinute.Text}";
                }
                if (btnAMPM.Text == "AM" && txtHour.Text == "12")
                    time = $"0:{txtMinute.Text}";

                Reservation reservation = new Reservation(customerIDs[lstCustomers.SelectedIndex], numberOfPeople, date, time);
                Table table = reservation.SearchForTable();
                if (table != null)
                {
                    table.Reserve();
                    reservation.UpdateReservationsTable(table);
                    bool isSuccess = reservation.UpdateCustomersTable();
                    lstCustomers.Items.Remove(lstCustomers.SelectedItem);
                    if (isSuccess)
                        MessageBox.Show($"Successfully reserved table {table.TableID} for {username}. Reservation will be at {date}, {time}.");
                    else
                        MessageBox.Show("Something went wrong!!");
                }
                else
                {
                    MessageBox.Show("There is no available table at the moment or the number of people is too high to accomodate.");
                }
            }
        }
    }
}
