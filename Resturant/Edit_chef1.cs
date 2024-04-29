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
    public partial class Edit_chef1 : Form
    {
        public Edit_chef1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Password_chef password_Chef = new Password_chef();
            password_Chef.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chef_userNum num = new chef_userNum();
            num.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMAIL_EDIT eMAIL_EDIT = new EMAIL_EDIT();
            eMAIL_EDIT.Show();
            this.Hide();
        }
    }
}
