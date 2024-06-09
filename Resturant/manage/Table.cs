using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Resturant
{
    internal class Table
    {
        private int tableID;
        private int numberOfSeats = 0;

        public Table(int tableID)
        {
            this.GetTable(tableID);
        }

        private void GetTable(int tableID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand($"SELECT tableID, numberOfSeats FROM Tables WHERE tableID = {tableID};", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.tableID = (int)reader.GetValue(0);
                    numberOfSeats = (int)reader.GetValue(1);
                }
                else
                    throw new Exception("Please make sure you're not drunk.");
                reader.Close();
            }
        }

        public int NumberOfSeats { get { return numberOfSeats; } }

        public int TableID { get { return tableID; } }
    }
}
