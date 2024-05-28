using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.manage
{
    public partial class AddCatagory : Form
    {
        public string newCatagory;
        public AddCatagory()
        {
            InitializeComponent();
        }
        private void btnAddCatagory_Click(object sender, EventArgs e)
        {
            string newCat = txtNewCatagory.Text;
            if (newCat != null)
            {
                Catagory catagory = new Catagory(newCat);
                bool isSuccess = catagory.Upload();
                if (isSuccess)
                {
                    MessageBox.Show("Add catagory successfully!");
                    newCatagory = txtNewCatagory.Text;
                }
                else
                    MessageBox.Show("This catagory already exists!");
                Close();
            }
        }
    }
}
