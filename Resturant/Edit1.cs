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
    public partial class Edit1 : Form
    {
        public Edit1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit_2 edit_2 = new edit_2();
            edit_2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_password manager_Delete = new Manager_password();
            manager_Delete.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_email manager_Email = new Manager_email();
            manager_Email.Show();
            this.Hide();
        }
    }
}
