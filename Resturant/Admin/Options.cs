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
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update update1 = new Update();
            update1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Users editUsers = new Edit_Users();
            editUsers.Show();
            this.Hide();
        }

        private void FedBack_Click(object sender, EventArgs e)
        {
            FeedBack1 feedBack1 = new FeedBack1();
            feedBack1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Feed___Back feed___Back = new Feed___Back();
            feed___Back.Show();
        }
    }
}
