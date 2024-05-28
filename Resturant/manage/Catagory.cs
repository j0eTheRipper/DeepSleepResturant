using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.manage
{
    internal class Catagory: RecordManager
    {
        private List<string> items;

        public Catagory(string name)
        {
            this.name = name;
            this.tableName = "Catagory";
        }

        public override bool Upload()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                bool catagoryExists = CheckRecordExistence();
                if (!catagoryExists)
                {
                    SqlCommand addNewCat = new SqlCommand("INSERT INTO Catagory VALUES (@name);", connection);
                    addNewCat.Parameters.AddWithValue("name", name);
                    connection.Open();
                    addNewCat.ExecuteNonQuery();
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
