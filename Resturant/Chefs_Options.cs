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
    public partial class Chefs_Options : Form
    {
        public Chefs_Options()
        {
            InitializeComponent();
        }

        private void Add1chef_Click(object sender, EventArgs e)
        {
            Chef_op2 chef = new Chef_op2();
            chef.Show();
            this.Close();
        }

        private void Edit1chef_Click(object sender, EventArgs e)
        {
           Edit_chef1 chef = new Edit_chef1();
            chef.Show();
            this.Close();
        }

        private void Delete1chef_Click(object sender, EventArgs e)
        {
            DELET_CHEF dELET_CHEF = new DELET_CHEF();
            dELET_CHEF.Show();
            this.Close();
        }
    }
}
