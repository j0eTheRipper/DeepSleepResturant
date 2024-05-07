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
    public partial class Manager_Options : Form
    {
        public Manager_Options()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser add_manager = new AddUser();
            add_manager.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
