using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Customer
{
    public partial class cReservation : Form
    {
        private string username;
        private int customerID;

        public cReservation(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void reservationDetails1_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("SELECT CustomerID FROM Customer WHERE username=@username;", connection);
                cmd.Parameters.AddWithValue("username", username);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                customerID = reader.GetInt32(0);
            }
            string reservationStatus = GetReservationStatus(customerID);
            lablReS.Text = $"Your Reservation Status is: {reservationStatus}";

        }
        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            string date = reservationDetails1.Date;
            string inTime = reservationDetails1.StartTime;
            string outTime = reservationDetails1.EndTime; 
            int numberOfPeople = reservationDetails1.NumberOfPeople;

            if (inTime == null || outTime == null || numberOfPeople == 0)
                MessageBox.Show("please specify a date and time");
            else
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
                {
                    string query = "select * from reservations where CustomerID = @customerID and reservationDate >= convert(date, getdate());";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerID", customerID);
                        connection.Open();
                        SqlDataReader result = command.ExecuteReader();

                        if (result.Read())
                        {
                            MessageBox.Show("You already have an existing reservation.");
                        }
                        else
                        {
                            RequestReservation reservation = new RequestReservation(customerID, numberOfPeople, date, inTime, outTime);
                            bool success = reservation.MakeReservationTable();
                            if (success)
                                MessageBox.Show($"The request has been sent");
                            else
                                MessageBox.Show("There is no available table at the moment or the number of people is too high to accomodate.");
                        }
                    }



                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string GetReservationStatus(int customerId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                string query = "select Reservation from Customer where CustomerID=@customerID and Reservation is not null;";
                string reservationStatus = "Pending";

                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("customerID", customerId);


                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        reservationStatus = "Approved";
                    }
                    reader.Close();
                }

                return reservationStatus;

            }


        }

        private void cReservation_Load(object sender, EventArgs e)
        {

        }
    }
}
