using ApiFlora.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlora.Class
{
    public class UpdatePlant
    {
        public static bool InPot(string plant, string pot)
        {
            string query = "UPDATE `pots` SET `plant` = '" + plant + "' WHERE `pots`.`pot_id` = " + pot + "";
            return DbClass.StoreDb(query);
        }

    }
}
