using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            string date = reservationDetailsFilter.Date;
            string timeIn = reservationDetailsFilter.StartTime;
            string timeOut = reservationDetailsFilter.EndTime;
            int numberOfPeople = reservationDetailsFilter.NumberOfPeople;

            string query = "SELECT reservationID, Customer.username, Tables.numberOfSeats, reservationStartTime as Start, reservationEndTime as [End], reservationDate as date FROM reservations inner join Tables on Tables.tableID = reservations.tableID inner join Customer on Customer.CustomerID = reservations.customerID ";
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

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            int.TryParse(txtReservationID.Text, out int reservationID);
            reservationDetailsFilter.loadReservationData(reservationID);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reservationDetailsFilter.ClearData();
            btnSubmit_Click(sender, e);
        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {
            if (txtReservationID.Text != null)
            {
                bool confirmation = MessageBox.Show("Are you sure you want to edit this reservation?", "confrim", MessageBoxButtons.YesNo) == DialogResult.Yes;
                if (!confirmation)
                    return;

                int.TryParse(txtReservationID.Text, out int reservationID);
                string inTime = reservationDetailsFilter.StartTime;
                string outTime = reservationDetailsFilter.EndTime;
                int numberOfPeople = reservationDetailsFilter.NumberOfPeople;
                string date = reservationDetailsFilter.Date;
                if (inTime == null || outTime == null || numberOfPeople == 0 || DateTime.Parse(outTime) < DateTime.Parse(inTime))
                {
                    MessageBox.Show("please enter a valid time and number of people");
                }
                else
                {
                    Reservation oldReservation = new Reservation(reservationID);
                    Reservation newReservation = new Reservation(oldReservation.CustomerID, numberOfPeople, date, inTime, outTime);
                    bool success = oldReservation.ChangeReservation(newReservation);
                    if (success)
                    {
                        MessageBox.Show("Successfuly updated your reservation.");
                        btnSubmit_Click(sender, e);
                    }
                }
            }
            else MessageBox.Show("Please enter a reservation ID");
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            int.TryParse(txtReservationID.Text, out int reservationID);
            if (reservationID != 0)
            {
                bool confirmation = MessageBox.Show("are you sure you want to delete this reservation?", "are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes;
                if (!confirmation)
                    return;

                Reservation reservation = new Reservation(reservationID);
                bool success = reservation.DeleteReservation();
                if (success)
                    MessageBox.Show("Reservation has been successfuly deleted.");
                else
                    MessageBox.Show("Reservation has not been deleted, something went wrong.");
            }
            else MessageBox.Show("please enter a reservationID");
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            NewReservation request = new NewReservation();
            request.ShowDialog();
            btnClear_Click(sender, e);
        }

        private void btnApproveReservation_Click(object sender, EventArgs e)
        {
            ReservationRequest request = new ReservationRequest();
            request.ShowDialog();
            btnClear_Click(sender, e);
        }

        private void frmViewReservations_Load(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
        }
    }
}
