using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Resturant.Properties;


namespace Resturant.Customer
{
    internal class CustomerFeedback
    {


        // Method to add feedback
        public bool AddFeedback(int customerId, string feedback)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))

            {
                string query = "INSERT INTO dbo.Feedback (CustomerID, Feedback) VALUES (@CustomerId, @Feedback)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@Feedback", feedback);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        // Method to get feedback
        public List<Feedback> GetFeedback()
        {
            List<Feedback> feedbackList = new List<Feedback>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                string query = "SELECT FeedbackID, CustomerID, Feedback FROM dbo.Feedback";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Feedback feedback = new Feedback
                        {
                            FeedbackID = reader.GetInt32(0),
                            CustomerID = reader.GetInt32(1),
                            FeedbackText = reader.GetString(2)
                        };

                        feedbackList.Add(feedback);
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return feedbackList;
        }
    }

    // Class to represent feedback data
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int CustomerID { get; set; }
        public string FeedbackText { get; set; }
    }
}

