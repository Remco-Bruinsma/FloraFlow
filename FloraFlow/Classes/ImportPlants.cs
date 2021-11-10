using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow
{
    public class ImportPlants
    {
        private static MySqlConnection databaseConnection = new MySqlConnection("Datasource=127.0.0.1;port=3306;username=root;password=;database= floraflow;");
        public static void Check_databaseConnectionState(MySqlConnection databaseConnection)
        {
            if (databaseConnection.State == System.Data.ConnectionState.Open)
            {
                databaseConnection.Close();
            }
        }
        public static List<string> ImportPlantNames()
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `plantName` FROM `plants`");
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

            /*PlantModel Flamingoplant = new PlantModel("flamingoplant", 250, 604800000, "Anthurium of flamingoplant is een tropische plant die erg populair is als kamerplant. Dat heeft meerdere redenen: de anthuriums zijn gemakkelijk in onderhoud en daarnaast zijn ze in veel verschillende kleuren beschikbaar. Door de kleur en vorm zal de anthurium echt opvallen in uw huis!");

            plants.AddRange(new List<PlantModel> { Flamingoplant });
            return plants;*/


        }

    }

}
