using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlora
{
    public class PotsModel
    {
        /*public CustomerModel Customer { get; set; }*///work in progress
        public int Pot_ID { get; set; } = 0;
        public int Amount { get; set; } = 0;
        public PlantModel Plant { get; set; }
        public int Soil_hydration { get; set; } = 0;// needs a tcp websocket
        public string Customer_code { get; set; } 
    }
    
}
