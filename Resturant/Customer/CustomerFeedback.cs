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


        public static bool AddFeedBack(string Feddback, string Service, string Satisfactioon, int id)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                connection.Open();
                SqlCommand addeddfeed_back = new SqlCommand($"INSERT INTO Feedback(Feedback, Service, Satisfaction, CustomerID) VALUES ('{Feddback}',  '{Service}', '{Satisfactioon}', {id})", connection);
                int isfeedback_added = addeddfeed_back.ExecuteNonQuery();
                connection.Close();
                return isfeedback_added == 1;
            }
        }   
    }
}