using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//here i put in my plant model this is the blueprint of my plant
namespace FloraFlow.Models
{
    public class PlantModel
    {
        private int id;

        private string plant_name;

        private int use_of_water;

        private int time_delay;

        private string plant_description;

        private string url;

        private int hydration_needed;


        public int Id { get => id; set => id = value; }
        public string Plant_name { get => plant_name; set => plant_name = value; }
        public int Use_of_water { get => use_of_water; set => use_of_water = value; }
        public int Time_delay { get => time_delay; set => time_delay = value; }
        public string Plant_description { get => plant_description; set => plant_description = value; }
        public string Url { get => url; set => url = value; }
        public int Hydration_needed { get => hydration_needed; set => hydration_needed = value; }

    }
}
