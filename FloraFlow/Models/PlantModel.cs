using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//here i put in my plant model this is the blueprint of my plant
namespace FloraFlow.Models
{
    public class PlantModel
    {
        public int Id { get; set; } 
        public string Plant_name { get; set; } 
        public int Use_of_water { get; set; } 
        public int Time_delay { get; set; } 
        public string Plant_description { get; set; } 
        public string Url { get; set; } 
        public int Hydration_needed { get; set; } 

        
      

    }
}
