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
    public partial class ManageCatagory : Form
    {
        public string catagory;
        public ManageCatagory()
        {
            InitializeComponent();
        }

        public ManageCatagory(string catagory)
        {
            InitializeComponent();
            lblStatus.Text = $"Edit {catagory}";
            this.catagory = catagory;
            btnAddCatagory.Text = "Edit";
        }

        private void btnAddCatagory_Click(object sender, EventArgs e)
        {
            if (txtNewCatagory.Text == "")
                return;
            if (btnAddCatagory.Text == "Edit")
                UpdateCatagory();
            else if (btnAddCatagory.Text == "Add")
                AddCatagory();
        }

        private void AddCatagory()
        {
            Catagory catagory = new Catagory(this.catagory);
            bool isSuccess = catagory.Upload();
            if (isSuccess)
            {
                MessageBox.Show("Add catagory successfully!");
                this.catagory = txtNewCatagory.Text;
            }
            else
                MessageBox.Show("This catagory already exists!");
            Close();
        }

        private void UpdateCatagory()
        {
            Catagory catagory = new Catagory(this.catagory);
            catagory.Edit(txtNewCatagory.Text);
        }
    }
}
