using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow.Classes
{
    public class DbClass
    {
        
        private static MySqlConnection databaseConnection = new MySqlConnection(/*"Datasource = 127.0.0.1; port=3306;username=root;password=;database= floraflow;"*/"Datasource = 192.168.160.124; port=3306;username=AppUser;password=@ppUs3r123;database= floraflow");
      
        public static List<string> GetFromDb(string command)
        {

            MySqlCommand sqlCommand = new MySqlCommand(command);
           
            List<string> results = new List<string> { };
            try
            {
                sqlCommand.Connection = databaseConnection;
                databaseConnection.Open();
                MySqlDataReader executeString = sqlCommand.ExecuteReader();
                while (executeString.Read())
                {
                    for (int i = 0; i < executeString.FieldCount; i++)
                    {
                        results.Add(executeString.GetValue(i).ToString());
                    }
                }
                databaseConnection.Close();
                return results;
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                return null;
            }

        }
     
        public static bool StoreDb(string command)
        {
            MySqlCommand sqlCommand = new MySqlCommand(command);
           
            try
            {
                sqlCommand.Connection = databaseConnection;
                databaseConnection.Open();
                MySqlDataReader executeString = sqlCommand.ExecuteReader();
                databaseConnection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                return false;
            }
        }
    }
}
