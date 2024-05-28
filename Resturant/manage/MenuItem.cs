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

namespace Resturant.manage
{
    internal class MenuItem: RecordManager
    {
        int itemID;
        string catagory;
        float price;
        Image image;

        public MenuItem(string name, string catagory, float price, string path)
        {
            this.name = name;
            this.catagory = catagory;
            this.price = price;
            this.tableName = "Item";
            image = Image.FromFile(path);
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
    }
}