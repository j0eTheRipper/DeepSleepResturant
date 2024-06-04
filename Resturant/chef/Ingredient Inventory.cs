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

namespace Resturant.chef
{
    public partial class Ingredient_Inventory : Form
    {
        private IngredientInventoryClass ingredientClass;

        public Ingredient_Inventory()               
        {
            InitializeComponent();
            ingredientClass = new IngredientInventoryClass();
        }

        private void Ingredient_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void txtIngredientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtIngredientName.Text;
            string type = txtType.Text;
            int quantity;

            if (int.TryParse(txtQuantity.Text, out quantity))      //if the quantity was a valid integer it will call the //
            {                                                                      // AddIngredient method//
                ingredientClass.AddIngredient(name, type, quantity);
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = txtIngredientName.Text;
            string type = txtType.Text;
            int quantity;

            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                ingredientClass.EditIngredient(name, type, quantity);
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtIngredientName.Text;
            ingredientClass.DeleteIngredient(name);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = ingredientClass.SearchIngredients();     //here will call the SearchIngredient method from class//
            DataGridView.DataSource = dt;                         // the data grid view will search and display the data table //
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIngredientName.Clear();
            txtType.Clear();
            txtQuantity.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChefMainPage mainPage = new ChefMainPage();
            mainPage.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
 
    
    
    
    
    
    }



    public class IngredientInventoryClass
    {
        private string connect;

        
        public IngredientInventoryClass()
        {
            connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mazin\\Source\\Repos\\iqxr36\\DeepSleepResturant\\Resturant\\Database1.mdf;Integrated Security=True";
        }


        public void AddIngredient(string name, string type, int quantity)       
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                try
                {
                    con.Open();         //to open the database//

                    SqlCommand cmd = new SqlCommand("INSERT INTO Ingredient (Name, Type, Quantity) VALUES (@Name, @Type, @Quantity)", con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    int rowsAffected = cmd.ExecuteNonQuery();               //ExecuteNonQuery is method for SQL command for insert,update, and delete
                                                                                                    //it executes the SQL command//
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully saved");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save. No rows affected!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void EditIngredient(string name, string type, int quantity)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Ingredient SET Type = @Type, Quantity = @Quantity WHERE Name = @Name", con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Edited");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void DeleteIngredient(string name)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Ingredient WHERE Name = @Name", con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public DataTable SearchIngredients()
        {
            DataTable dt = new DataTable();         //create datatable//
            using (SqlConnection con = new SqlConnection(connect))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Ingredient", con);       //to select all Ingredients in table//

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return dt;
        }
    }











}




