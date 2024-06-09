using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Admin
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            AddUser  addUser = new AddUser();
            addUser.Show();
            this.Hide();
            
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            var deleteUser = new DeleteUser();
            deleteUser.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var update1 = new Update();
            update1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var editUsers = new Edit_Users();
            editUsers.Show();
            this.Hide();
        }

        private void FedBack_Click(object sender, EventArgs e)
        {
            var feedBack1 = new Feed___Back();
            feedBack1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var feed___Back = new Feed___Back();
            feed___Back.Show();
            this.Hide();
        }

        private void View_Sales_Click(object sender, EventArgs e)
        {
            var view_Sales2 = new view_sales2();
            view_Sales2.Show();
            this.Hide();
        }
    }
}
