using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;

namespace Resturant
{
    internal class Reservation
    {
        private int id, customerID, numberOfPeople;
        Table table;
        private string date;
        private string inTime, outTime;

        public Reservation(int customerID, int numberOfPeople, string date, string time, string outTime)
        {
            this.customerID = customerID;
            this.numberOfPeople = numberOfPeople;
            this.date = date;
            this.inTime = time;
            this.outTime = outTime;
        }

        public Table SearchForTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand($"SELECT Tables.tableID FROM Tables left join reservations on reservations.tableID = Tables.tableID" +
                    $" WHERE ((reservations.reservationDate <> '{date}' or reservationDate is null) or " +
                    $"(reservationStartTime > '{outTime}') or (reservationEndTime < '{inTime}')) and " +
                    $"Tables.numberOfSeats >= {numberOfPeople};");
                connection.Open();
                cmd.Connection = connection;
                SqlDataReader reader = cmd.ExecuteReader();
                Table worstFitTable = null;
                while (reader.Read())
                {
                    Table table = new Table((int)reader.GetValue(0));
                    if (table.NumberOfSeats == numberOfPeople)
                    {
                        return table;
                    }
                    if (worstFitTable == null)
                        worstFitTable = table;
                    else if (table.NumberOfSeats - numberOfPeople < worstFitTable.NumberOfSeats - numberOfPeople)
                    {
                        worstFitTable = table;
                    }
                }
                return worstFitTable;
            }
        }

        public int UpdateReservationsTable(Table table)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand saveReservation = new SqlCommand($"INSERT INTO reservations (tableID, customerID, reservationDate, reservationStartTime, reservationEndTime) VALUES ({table.TableID}, {customerID}, '{date}', '{inTime}', '{outTime}'); SELECT CAST(scope_identity() as int);", connection);
                connection.Open();
                this.id = (int) saveReservation.ExecuteScalar();
                this.table = table;
                return this.id;
            }
        }

        public bool UpdateCustomersTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand updateCustomerRecord = new SqlCommand($"UPDATE Customer SET Reservation={this.id} WHERE CustomerID = {this.customerID};", connection);
                connection.Open();
                bool isSuccess = updateCustomerRecord.ExecuteNonQuery() == 1;
                if (isSuccess)
                    return true;
                else return false;
            }
        }
    }
}
