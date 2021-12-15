using ApiFlora.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlora.Classes
{
    public class DbClass
    {
        //here i setup my mySQL database connection 
        private static MySqlConnection con = new MySqlConnection(Connectionstring.InUse());
        //the methode of checking if the state database conection is open and close it so it doesnt mis use my bandwidth 
        public static void Check_databaseConnectionState(MySqlConnection con)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        //the methode of retreaving something from my database by open and closing it so it doesnt mis use my bandwidth  
        public static List<string> GetFromDb(string sc)
        {

            MySqlCommand sqlCommand = new MySqlCommand(sc);
            Check_databaseConnectionState(con);
            List<string> results = new List<string> { };
            try
            {
                sqlCommand.Connection = con;
                con.Open();
                MySqlDataReader executeString = sqlCommand.ExecuteReader();
                while (executeString.Read())
                {
                    for (int i = 0; i < executeString.FieldCount; i++)
                    {
                        results.Add(executeString.GetValue(i).ToString());
                    }
                }
                con.Close();
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
            Check_databaseConnectionState(con);
            try
            {
                sqlCommand.Connection = con;
                con.Open();
                MySqlDataReader executeString = sqlCommand.ExecuteReader();
                con.Close();
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
