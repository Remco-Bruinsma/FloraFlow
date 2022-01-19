using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow.Models
{
    //this is the model i use for my pots, this is the blueprint i use to make a new pot 
    public class PotModel
    {
        private int pot_ID;
        private int amount;
        private PlantModel plant;
        private int soil_hydration;
        public int Pot_ID { get=>pot_ID; set=>pot_ID=value; }
        public int Amount{ get=>amount; set => amount = value; }
        public PlantModel Plant{ get=>plant; set => plant = value; }
        public int Soil_hydration{ get=>soil_hydration; set => soil_hydration = value; }

    }


   
}
