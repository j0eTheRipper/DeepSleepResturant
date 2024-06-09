using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.manage
{
    public partial class ReservationRequest : Form
    {
        List<Reservation> reservations;
        public ReservationRequest()
        {
            InitializeComponent();
        }

        private void ReservationRequest_Load(object sender, EventArgs e)
        {
            reservations = Reservation.GetNonApproved();
            lstReservationRequests.Items.Clear();
            foreach (Reservation reservation in reservations)
            {
                string display = $"{reservation.ID} on {reservation.Date} at {reservation.InTime} to {reservation.OutTime} for {reservation.NumberOfPeople}";
                lstReservationRequests.Items.Add(display);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (lstReservationRequests.SelectedItem == null)
                return;
            reservations[lstReservationRequests.SelectedIndex].UpdateCustomersTable();
            ReservationRequest_Load(sender, EventArgs.Empty);
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            if (lstReservationRequests.SelectedItem == null)
                return;
            reservations[lstReservationRequests.SelectedIndex].DeleteReservation();
            ReservationRequest_Load(sender, EventArgs.Empty);
        }
    }
}
