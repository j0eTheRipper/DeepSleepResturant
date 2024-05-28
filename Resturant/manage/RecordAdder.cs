using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.manage
{
    internal abstract class RecordManager
    {
        protected string name, tableName;

        protected bool CheckRecordExistence()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                connection.Open();
                SqlCommand checkForSameItem = new SqlCommand($"SELECT * FROM {tableName} WHERE name=@name;", connection);
                checkForSameItem.CommandType = System.Data.CommandType.Text;
                checkForSameItem.Parameters.AddWithValue("@name", name);

                SqlDataReader reader = checkForSameItem.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else { return false; }
            }
        }

        public static List<string> GetAll(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand($"SELECT name from {tableName};", connection);
                List<string> allRecords = new List<string>();

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allRecords.Add(reader.GetString(0));
                }

                return allRecords;
            }
        }

        public abstract bool Upload();
    }
}
