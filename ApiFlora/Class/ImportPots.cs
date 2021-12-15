using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlora.Class
{
    public class ImportPots
    {
        public static List<PotsModel> PotsClassListMaker(List<PlantModel>plants,string Query)
        {
            List<PotsModel> pots = new List<PotsModel>();
            try
            {
                using var con = new MySqlConnection(Connectionstring.InUse());
                con.Open();
                var Potsselectsql = Query;
                using var cmd2 = new MySqlCommand(Potsselectsql, con);
                using MySqlDataReader rdr2 = cmd2.ExecuteReader();

                pots.Clear();
                while (rdr2.Read())
                {

                    PotsModel po = new PotsModel();
                    po.Pot_ID = Convert.ToInt32(rdr2["pot_id"]);
                    po.Amount = Convert.ToInt32(rdr2["amount"]);
                    po.Plant = plants.Where(x => x.Id == Convert.ToInt32(rdr2["plant"])).FirstOrDefault();
                    po.Soil_hydration = Convert.ToInt32(rdr2["soil_hydration"]);
                    po.Customer_code = rdr2["customer_code"].ToString();


                    pots.Add(po);
                }
                con.Close();

            }
            catch (Exception)
            {

                throw;
            }
            return pots;
        }
    }
    
}
