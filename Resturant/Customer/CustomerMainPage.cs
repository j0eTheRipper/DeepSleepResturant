using Resturant.Customer;
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
    public partial class CustomerMainPage : Form
    {
        public CustomerMainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cOrderFood CF2 = new cOrderFood();
            CF2.Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            cMenu CM2 = new cMenu();
            CM2.Show();

        }

        private void Reservation_Click(object sender, EventArgs e)
        {
            cReservation CR2 = new cReservation();
            CR2.Show();
        }

        private void S_feedback_Click(object sender, EventArgs e)
        {
            cFeedBack CF2 = new cFeedBack();
            CF2.Show();

        }

        private void View_order_Click(object sender, EventArgs e)
        {
            cViewOrder_Reservation CV2 = new cViewOrder_Reservation ();
            CV2.Show();
        }

        private void CustomerMainPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cOrderReservation COR2 = new cOrderReservation();
            COR2.Show();
        }
    }
}
