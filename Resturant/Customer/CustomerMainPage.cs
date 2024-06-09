using Resturant.Admin;
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
        string username;
        public CustomerMainPage(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            cMenu CM2 = new cMenu(username);
            CM2.Show();

        }

        private void Reservation_Click(object sender, EventArgs e)
        {
            cReservation CR2 = new cReservation(username);
            CR2.Show();
        }

        private void S_feedback_Click(object sender, EventArgs e)
        {
            cFeedback CF2 = new cFeedback(username);
            CF2.Show();

        }

        private void Update_profile_Click(object sender, EventArgs e)
        {
            Update UP2 = new Update();
            UP2.Show();
        }

        private void View_order_Click(object sender, EventArgs e)
        {
           
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

        
    }
}
