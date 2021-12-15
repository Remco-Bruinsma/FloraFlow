using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlora.Class
{
    public class Querys
    {
        public static string AllPlants()
        {
            string allplants = "SELECT * FROM plants";
            return allplants;
        }
        public static string AllPots()
        {
            string allpots = "SELECT* FROM pots";
            return allpots;
        }
        public static string UserPots(string code)
        {
            string userpots = $"SELECT * FROM pots WHERE customer_code = '{code}'";
            return userpots;
        }
    }
}
