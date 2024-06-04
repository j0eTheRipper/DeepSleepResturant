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

        public MenuItem(string name, string catagory, decimal price, string path)
        {
            this.name = name;
            this.catagory = catagory;
            this.price = price;
            this.tableName = "Item";
            image = Image.FromFile(path);
        }

        public MenuItem(string name)
        {
            this.name = name;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("SELECT catagory, price, picture FROM Item WHERE name=@name;", connection);
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
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    cmd.Parameters.AddWithValue("@picture", ms.ToArray());
                }
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
    }
}