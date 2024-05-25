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
        private Dictionary<string, int> customerIDs = new Dictionary<string, int>();
        public NewReservation()
        {
            InitializeComponent();
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
                    customerIDs[reader.GetString(1)] = reader.GetInt32(0);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = reservationDetails1.Date;
            string inTime = reservationDetails1.StartTime;
            string outTime = reservationDetails1.EndTime;
            int numberOfPeople = reservationDetails1.NumberOfPeople;
            object username = lstCustomers.SelectedItem;
            if (inTime == null || outTime == null || username == null || numberOfPeople == 0)
                MessageBox.Show("please select a customer and specify a date and time");
            else
            {
                Reservation reservation = new Reservation(customerIDs[(string) username], numberOfPeople, date, inTime, outTime);
                Table table = reservation.SearchForTable();
                if (table != null)
                {
                    reservation.UpdateReservationsTable(table);
                    bool isSuccess = reservation.UpdateCustomersTable();
                    lstCustomers.Items.Remove(lstCustomers.SelectedItem);
                    if (isSuccess)
                        MessageBox.Show($"Successfully reserved table {table.TableID} for {(string) username}. Reservation will be at {date}, {inTime}.");
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
