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
    public partial class EDIT_CUSTOMER : Form
    {
        public EDIT_CUSTOMER()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CUSTOMER_USERNUM cUSTOMER_USERNUM = new CUSTOMER_USERNUM();
            cUSTOMER_USERNUM.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CUSTOMER_EMAIL cUSTOMER_EMAIL = new CUSTOMER_EMAIL();
            cUSTOMER_EMAIL.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUSTOMER_PASSWORD cUSTOMER_PASSWORD = new CUSTOMER_PASSWORD();
            cUSTOMER_PASSWORD.Show();
            this.Hide();
        }
    }
}
