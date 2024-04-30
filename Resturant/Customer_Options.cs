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
    public partial class Customer_Options : Form
    {
        public Customer_Options()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EDIT_CUSTOMER eDIT_CUSTOMER = new EDIT_CUSTOMER();
            eDIT_CUSTOMER.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADDING_CUSTOMERcs aDDING_CUSTOMERcs = new ADDING_CUSTOMERcs();
            aDDING_CUSTOMERcs.Show();
            this.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
