﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow.Models
{
    public class Potmodel
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public PlantModel Plant { get; set; }
/*        public Potmodel(int pot, int amount, string name, int water, int milliseconds, string description)
        {
            this.Pot = pot;
            this.Amount = amount;
            this.Plant_name = name;
            this.Use_of_water = water;
            this.Time_delay = milliseconds;
            this.Plant_description = description;

        }*/
    }
   
}
