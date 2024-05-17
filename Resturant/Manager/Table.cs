using Resturant.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant
{
    internal class Table
    {
        private int numberOfSeats, tableNumber;
        private bool isReserved;
        private User reservingCustomer;
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\j0eTh\\source\\repos\\Resturant\\Resturant\\Database1.mdf;Integrated Security=True";

        public Table ReserveTable(int numberOfSeats, User reservingCustomer)
        {
            this.numberOfSeats = numberOfSeats;
            this.reservingCustomer = reservingCustomer;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Tables WHERE numberOfSeats = {numberOfSeats} and CustomerReserved = NULL;", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0])
                }
            }
        }
    }
}
