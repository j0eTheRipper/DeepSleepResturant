using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.manage
{
    public partial class EditOrAddItem : Form
    {
        private string path;
        private MenuItem item;
        public EditOrAddItem()
        {
            InitializeComponent();
        }

        public EditOrAddItem(string name)
        {
            InitializeComponent();
            item = new MenuItem(name);
            picItem.Image = item.Image;
            txtName.Text = item.Name;
            txtPrice.Text = item.Price.ToString();
            LoadAllCatagories();
            cmbCatagories.SelectedItem = item.Catagory;
            btnUpload.Text = "Edit";
            lblItemImage.Text = "";
            this.Text = "Edit Item";
        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            LoadAllCatagories();
        }

        private void picItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "picture files (*.png) | *.png";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    picItem.Image = Image.FromFile(openFileDialog.FileName);
                    lblItemImage.Text = null;
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (btnUpload.Text == "Add")
                AddItem();
            else
                EditItem();
        }

        private void cmbCatagories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCatagories.SelectedItem.ToString() == "Add new catagory")
            {
                AddCatagory frmNewCatagory = new AddCatagory();
                frmNewCatagory.ShowDialog();
                LoadAllCatagories();
            }
        }

        private void LoadAllCatagories()
        {
            cmbCatagories.Items.Clear();
            foreach (string catagory in Catagory.GetAll("Catagory"))
                cmbCatagories.Items.Add(catagory);
            cmbCatagories.Items.Add("Add new catagory");
        }

        private void AddItem()
        {
            if (txtName.Text != null && cmbCatagories.SelectedItem != null && txtPrice.Text != null && path != null)
            {
                MenuItem item = new MenuItem(txtName.Text, cmbCatagories.SelectedItem.ToString(), decimal.Parse(txtPrice.Text), picItem.Image);
                bool isSuccesful = item.Upload();
                if (isSuccesful)
                    MessageBox.Show("added succesfuly");
                else
                    MessageBox.Show("This item already exists, please add a different item or edit it from the editing menu!");
                this.Close();
            }
            else
                MessageBox.Show("please fill all the required fields");
        }

        private void EditItem()
        {
            decimal.TryParse(txtPrice.Text, out decimal price);
            MenuItem newItem = new MenuItem(txtName.Text, cmbCatagories.Text, price, picItem.Image);
            bool success = item.Edit(newItem);
            if (success)
                MessageBox.Show("Successfully updated item.");
            else
                MessageBox.Show("Failed :(");
            this.Close();
        }
    }
}
