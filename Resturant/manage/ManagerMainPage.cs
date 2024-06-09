using Resturant.Admin;
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

        private void lnkReservationReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewReservations frm = new frmViewReservations();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void lnkMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewAndEditItems frmView = new ViewAndEditItems();
            Hide();
            frmView.ShowDialog();
            Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Update updateProfile = new Update();
            Hide();
            updateProfile.ShowDialog();
            Show();
        }
    }
}
