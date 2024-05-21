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

            // to connect to the database//
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mazin\\Source\\Repos\\iqxr36\\DeepSleepResturant\\Resturant\\Database1.mdf;Integrated Security=True");

            try
            {
                con.Open();       //to open the database//

                SqlCommand cmd = new SqlCommand("INSERT INTO Ingredient (Name, Type, Quantity) VALUES (@Name, @Type, @Quantity)", con);
                cmd.Parameters.AddWithValue("@Name", txtIngredientName.Text);
                cmd.Parameters.AddWithValue("@Type", txtType.Text);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));

                int rowsAffected = cmd.ExecuteNonQuery();             //ExecuteNonQuery is method for SQL command for insert,update, and delete

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully saved");
                }
                else
                {
                    MessageBox.Show("Failed to save No rows affected!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();        //close the database//
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mazin\\Source\\Repos\\iqxr36\\DeepSleepResturant\\Resturant\\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand ("update Ingredient set Name = @Name, Type = @Type, Quantity = @Quantity",con); 
            
            cmd.Parameters.AddWithValue("@Name", txtIngredientName.Text);
            cmd.Parameters.AddWithValue("@Type", txtType.Text);
            cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            
            MessageBox.Show("Succesfully Edited");
            








        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mazin\\Source\\Repos\\iqxr36\\DeepSleepResturant\\Resturant\\Database1.mdf;Integrated Security=True");
               
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete Ingredient where Name = @Name" , con);

            cmd.Parameters.AddWithValue("@Name", txtIngredientName.Text);
            cmd.ExecuteNonQuery();
            
            con.Close();
            MessageBox.Show("Successfully Deleted");











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

        private void Ingredients_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mazin\\Source\\Repos\\iqxr36\\DeepSleepResturant\\Resturant\\Database1.mdf;Integrated Security=True");
                
                con.Open();
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ingredient", con);       //to select all records in Ingredients table//
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);       
                
                DataTable dt = new DataTable();
                
                adapter.Fill(dt);
                
                DataGridView.DataSource = dt;
                
                
                con.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }





}
