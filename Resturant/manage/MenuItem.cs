using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace Resturant.manage
{
    internal class MenuItem: RecordManager
    {
        int itemID;
        string catagory;
        decimal price;
        Image image;

        public Image Image { get => image;}
        public decimal Price { get => price;}
        public string Catagory { get => catagory;}
        public string Name { get => name;}

        public int ItemID { get => itemID;}

        public MenuItem(string name, string catagory, decimal price, Image image)
        {
            this.name = name;
            this.catagory = catagory;
            this.price = price;
            this.tableName = "Item";
            this.image = image;
        }

        public MenuItem(string name)
        {
            this.name = name;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("SELECT catagory, price, picture, itemID FROM Item WHERE name=@name;", connection);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("name", name);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                this.catagory = reader.GetString(0);
                price = reader.GetDecimal(1);
                byte[] image = (byte[])reader.GetValue(2);
                using (MemoryStream ms = new MemoryStream(image))
                {
                    this.image = Image.FromStream(ms);
                }
                itemID = reader.GetInt32(3);
            }
        }

        public override bool Upload()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Item (name, price, catagory, picture) values (@name, @price, @catagory, @picture);", connection);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@catagory", catagory);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@picture", ConvertImgToBytes());
                bool alreadyExists = CheckRecordExistence();
                if (!alreadyExists)
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        private byte[] ConvertImgToBytes()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static List<string> FilterCatagory(string catagory)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("SELECT name from Item WHERE catagory = @catagory;", connection);
                cmd.Parameters.AddWithValue("catagory", catagory);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> result = new List<string>();
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
                return result;
            }
        }

        public bool Edit(MenuItem newItem)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Item set name=@name, price=@price, catagory=@catagory, picture=@picture" +
                    " WHERE itemID=@id;", connection);
                cmd.Parameters.AddWithValue("catagory", newItem.catagory);
                cmd.Parameters.AddWithValue("name", newItem.name);
                cmd.Parameters.AddWithValue("price", newItem.Price);
                cmd.Parameters.AddWithValue("picture", newItem.ConvertImgToBytes());
                cmd.Parameters.AddWithValue("id", this.itemID);
                connection.Open();
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public bool Delete()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Item WHERE itemID=@id;", connection);
                cmd.Parameters.AddWithValue("id", itemID);
                connection.Open();
                return cmd.ExecuteNonQuery() == 1;
            }
        }
    }
}