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
    public partial class Feed___Back : Form
    {
        public Feed___Back()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            listViewFb.View = View.Details;
            listViewFb.Columns.Add("ID");
            listViewFb.Columns.Add("Feedback");
            listViewFb.Columns.Add("Username");
            listViewFb.Columns.Add("Service");
            listViewFb.Columns.Add("Satisified"); 
            List<User> users = new List<User>();
            users = User.GetAllUsers();
            foreach (User user in users)
            {
                listViewFb.Items.Add(new ListViewItem(new string[] { user.username, user.email, user.role, user.password }));
            }
            listViewFb.GridLines = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
