using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Resturant
{
    internal class RequestReservation : Reservation
    {
        public RequestReservation(int customerID, int numberOfPeople, string date, string time, string outTime) : base(customerID, numberOfPeople, date, time, outTime)
        { }

        public Table MakeReservationTable()
        {
            Table newTable = SearchForTable();

            if (newTable != null)
            {
                UpdateReservationsTable(newTable);
            }

            return newTable;
        }
    }
}