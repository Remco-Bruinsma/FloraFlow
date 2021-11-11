using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow.Classes
{
    public class DbClass
    {
        private static MySqlConnection databaseConnection = new MySqlConnection("Datasource=127.0.0.1;port=3306;username=root;password=;database= floraflow;");
        public static void Check_databaseConnectionState(MySqlConnection databaseConnection)
        {
            if (databaseConnection.State == System.Data.ConnectionState.Open)
            {
                databaseConnection.Close();
            }
        }
        public static List<string> GetFromDb(string command)
        {
            MySqlCommand sqlCommand = new MySqlCommand(command);
            Check_databaseConnectionState(databaseConnection);
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
            Check_databaseConnectionState(databaseConnection);
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
