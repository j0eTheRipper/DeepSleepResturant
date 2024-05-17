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
        private bool isReserved;

        public Table(int tableID)
        {
            this.GetTable(tableID);
        }

        private Table() { }

        private void GetTable(int tableID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand($"SELECT tableID, numberOfSeats, isReserved FROM Tables WHERE tableID = {tableID};", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.tableID = (int)reader.GetValue(0);
                    numberOfSeats = (int)reader.GetValue(1);
                    isReserved = (bool)reader.GetValue(2);
                }
                else
                    throw new Exception("Please make sure you're not drunk.");
                reader.Close();
            }
        }

        public bool Reserve()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand updateTableInfo = new SqlCommand($"UPDATE Tables SET isReserved = 1 WHERE tableID = {tableID};", connection);
                connection.Open();
                bool isSuccess = updateTableInfo.ExecuteNonQuery() == 1;
                if (isSuccess)
                {
                    isReserved = true;
                    return true;
                }
                else
                    return false;
            }
        }

        public int NumberOfSeats { get { return numberOfSeats; } }

        public bool IsReserved { get { return isReserved; } }

        public int TableID { get { return tableID; } }
    }
}
