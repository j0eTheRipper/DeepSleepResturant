using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int CustomerID { get; set; }
        public string FeedbackText { get; set; }
    }

    public class FeedbackService : IFeedbackService
    {
        private string connectionString;

        public FeedbackService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void SaveFeedback(Feedback feedback)
            using (SqlConnection connection = new SqlConnection())
            {
               string query = "INSERT INTO Feedback (CustomerID, Feedback) Values (@CustoemrID. Feeddback) ";
            
            }

    }
    
}
