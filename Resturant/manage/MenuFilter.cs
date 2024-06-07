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
    public partial class MenuFilter : UserControl
    {
        public string SelectedMenuItem {get => lstMenuItems.SelectedItem != null ? lstMenuItems.SelectedItem.ToString() : null;}

        public MenuFilter()
        {
            InitializeComponent();
        }

        private void lstMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMenuItems.SelectedItem == null)
                return;
            MenuItem item = new MenuItem(lstMenuItems.SelectedItem.ToString());
            picMenuImage.Image = item.Image;
            lblPrice.Text = item.Price.ToString();
            lblName.Text = item.Catagory.ToString();
        }

        public void Clear()
        {
            picMenuImage.Image = null;
            lblPrice.Text = null;
            lblName.Text = null;
        }

        private void MenuFilter_Load(object sender, EventArgs e)
        {
            FillMenuListBox();
            FillCatagories();
        }

        private void cmbCatagoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCatagoryFilter.SelectedIndex == 0)
            {
                FillMenuListBox();
            } 
            else
            {
                lstMenuItems.Items.Clear();
                foreach (string item in MenuItem.FilterCatagory(cmbCatagoryFilter.SelectedItem.ToString()))
                {
                    lstMenuItems.Items.Add(item);
                }
            }
        }

        public void FillMenuListBox()
        {
            lstMenuItems.Items.Clear();
            foreach (string itemName in MenuItem.GetAll("Item"))
            {
                lstMenuItems.Items.Add(itemName);
            }
        }

        public void FillCatagories()
        {
            cmbCatagoryFilter.Items.Clear();
            cmbCatagoryFilter.Items.Add("Show all");
            foreach (string catagoryName in Catagory.GetAll("Catagory"))
            {
                cmbCatagoryFilter.Items.Add(catagoryName);
            }
            cmbCatagoryFilter.SelectedIndex = 0;
        }
    }
}
