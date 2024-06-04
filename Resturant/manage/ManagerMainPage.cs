using Resturant.manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class ManagerMainPage : Form
    {
        public ManagerMainPage()
        {
            InitializeComponent();
        }

        private void ManagerMainPage_Load(object sender, EventArgs e)
        {

        }

        private void lnkReservation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void lnkReserveForCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewReservation newReservation = new NewReservation();
            newReservation.ShowDialog();
        }

        private void lnkReservationReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewReservations frm = new frmViewReservations();
            frm.ShowDialog();
        }

        private void lnkMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewAndEditItems frmView = new ViewAndEditItems();
            frmView.ShowDialog();
        }
    }
}
