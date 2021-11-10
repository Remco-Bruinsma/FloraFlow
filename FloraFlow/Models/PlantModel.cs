using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow
{
    public class PlantModel
    {
        public string Plant_name { get; set; }
        public int Use_of_water { get; set; }
        public int Time_delay { get; set; }
        public string Plant_description { get; set; }

        public PlantModel(string name, int water, int milliseconds, string description)
        {
            this.Plant_name = name;
            this.Use_of_water = water;
            this.Time_delay = milliseconds;
            this.Plant_description = description;

        }

    }
}
