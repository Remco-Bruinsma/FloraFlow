using ApiFlora.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlora
{
    public class ImportPlants
    {
        public static List<PlantModel>PlantClassListMaker()
        {
            List<PlantModel> plants = new List<PlantModel>();
            try
            {
                
                using var con = new MySqlConnection(Connectionstring.InUse());
                con.Open();
                var plantselectsql = Querys.AllPlants();
                using var cmd1 = new MySqlCommand(plantselectsql, con);
                using MySqlDataReader rdr1 = cmd1.ExecuteReader();

                plants.Clear();
                while (rdr1.Read())
                {

                    int Id = Convert.ToInt32(rdr1["id"]);
                    string Plant_name = rdr1["plant_name"].ToString();
                    int Use_of_water = Convert.ToInt32(rdr1["use_of_water"]);
                    int Time_delay = Convert.ToInt32(rdr1["time_delay"]);
                    string Plant_description = rdr1["plant_description"].ToString();
                    string Url = rdr1["url"].ToString();
                    int Hydration_needed = Convert.ToInt32(rdr1["hydration_needed"]);
                    
                    PlantModel pl = new PlantModel(Id, Plant_name, Use_of_water, Time_delay, Plant_description, Url, Hydration_needed);

                    plants.Add(pl);

                }
                con.Close();
                
            }
            catch (Exception)
            {
                Console.WriteLine("data base error ");
                throw;
            }
            return plants;
        }
    }
}