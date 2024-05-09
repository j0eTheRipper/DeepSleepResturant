using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.chef
{
    public partial class Ingredients_Inventory : Form
    {
        public Ingredients_Inventory()
        {
            InitializeComponent();
        }

        private void Ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {



        }




        
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Ingredients.Items.Add(txtAdd.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Ingredients.SelectedIndex > -1)
                Ingredients.Items[Ingredients.SelectedIndex] = txtEdit.Text;
            else
                MessageBox.Show("Select an item in listbox");
            txtEdit.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Ingredients.Items.Remove(txtDelete.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Ingredients.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChefMainPage mainPage = new ChefMainPage();
            mainPage.Show();
            this.Hide();
        }
    }





}
