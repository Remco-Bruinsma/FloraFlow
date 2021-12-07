using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow.Models
{
    //this is the model i use for my pots, this is the blueprint i use to make a new pot 
    public class Potmodel
    {
        

        /*public CustomerModel Customer { get; set; }*/
        public int Pot_ID { get; set; } = 0;
        public int Amount { get; set; } = 0;
        public PlantModel Plant { get; set; }
        public int Soil_hydration { get; set; } = 0;

    }


   
}
