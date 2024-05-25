using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.manage
{
    public partial class frmViewReservations : Form
    {
        public frmViewReservations()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string date = reservationDetails1.Date;
            string timeIn = reservationDetails1.StartTime;
            string timeOut = reservationDetails1.EndTime;
            int numberOfPeople = reservationDetails1.NumberOfPeople;

            string query = "SELECT Customer.username, Tables.numberOfSeats, reservationStartTime as Start, reservationEndTime as [End], reservationDate as date FROM reservations inner join Tables on Tables.tableID = reservations.tableID inner join Customer on Customer.CustomerID = reservations.customerID ";
            string whereClause = "WHERE ";
            if (chbxIncludeDate.Checked)
                whereClause += $"reservationDate >= '{date}' and ";
            if (timeIn != null)
                whereClause += $"reservationStartTime >= '{timeIn}' and ";
            if (timeOut != null)
                whereClause += $"reservationEndTime <= '{timeOut}' and ";
            if (numberOfPeople != 0)
                whereClause += $"Tables.numberOfSeats >= {numberOfPeople};";
            else
                whereClause += "reservations.reservationID is not null;";

            query += whereClause;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReservations.DataSource = dt;
            }
        }
    }
}
