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

        public int NumberOfPeople { get => numberOfPeople; }
        public string Date { get => date; }
        public string InTime { get => inTime; }
        public string OutTime { get => outTime; }
        public int CustomerID { get => customerID; }
        public int ID { get => id; }
        public Reservation(int customerID, int numberOfPeople, string date, string time, string outTime)
        {
            this.customerID = customerID;
            this.numberOfPeople = numberOfPeople;
            this.date = date;
            this.inTime = time;
            this.outTime = outTime;
        }

        public Reservation(int reservationID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("SELECT tableID, reservationDate, reservationStartTime, reservationEndTime, customerID from reservations WHERE reservationID = @id;", connection);
                cmd.Parameters.AddWithValue("id", reservationID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    table = new Table(reader.GetInt32(0));
                    date = reader.GetDateTime(1).Date.ToString("yyyy-MM-dd");
                    inTime = reader.GetTimeSpan(2).ToString();
                    outTime = reader.GetTimeSpan(3).ToString();
                    customerID = reader.GetInt32(4);
                    numberOfPeople = table.NumberOfSeats;
                    id = reservationID;
                }
            }
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

        public bool ChangeReservation(Reservation newReservation)
        {
            bool deletionSuccess = DeleteReservation();
            if (!deletionSuccess)
            {
                return false;
            }
            Table table = newReservation.SearchForTable();
            if (table != null)
            {
                newReservation.UpdateReservationsTable(table);
                newReservation.UpdateCustomersTable();
                return true;
            } else
            {
                UpdateReservationsTable(table);
                UpdateCustomersTable();
                return false;
            }
        }

        public bool DeleteReservation()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET Reservation = Null where customerID = @customerID;" +
                    "DELETE FROM reservations WHERE reservationID = @id;", connection);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("customerID", customerID);
                connection.Open();
                int x = cmd.ExecuteNonQuery();
                return x == 2;
            }
        }

        public static List<Reservation> GetNonApproved()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("SELECT reservations.reservationID FROM reservations " +
                    "JOIN Customer on Customer.CustomerID = reservations.CustomerID " +
                    "JOIN Tables on Tables.tableID = reservations.tableID" +
                    " WHERE customer.Reservation IS NULL AND reservationDate > GETDATE();", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Reservation> list = new List<Reservation>();
                while (reader.Read())
                {
                    list.Add(new Reservation(reader.GetInt32(0)));
                }
                return list;
            }
        }
    }
}
