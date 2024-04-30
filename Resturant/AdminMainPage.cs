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
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            Manager_Options Choices1 = new Manager_Options();
            Choices1.Show();
            this.Hide();
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            Customer_Options Customer1 = new Customer_Options();
            Customer1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            Chefs_Options added  = new Chefs_Options();
            added.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
