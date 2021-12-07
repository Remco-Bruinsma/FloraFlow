using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow
{
    public class ImportPlants
    {
        private static MySqlConnection databaseConnection = new MySqlConnection("Datasource=127.0.0.1;port=3306;username=root;password=;database= floraflow;"/*"Datasource=192.168.160.124;port=3306;username=AppUser;password=@ppUs3r123;database= floraflow"*/);
        public static List<string> ImportPlantNames()
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `plant_name` FROM `plants`");
            List<string> results = new List<string> { };
            try
            {
                //here i try to conect to the server and closeing it so it doesnt use alot of bandwidth 
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
        //here i import the images in my c# 
        public static List<string> ImportPlantImg()
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `url` FROM `plants`");
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

    }

}
