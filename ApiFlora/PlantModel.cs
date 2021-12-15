using System;

namespace ApiFlora
{
    public class PlantModel
    {
        
        public  int Id { get; }
        public  string Plant_name { get; }
        public  int Use_of_water{ get; }
        public  int Time_delay { get; }
        public  string Plant_description { get; }
        public  string Url { get; }
        public  int Hydration_needed { get; }
        


        public PlantModel(int id,string plant_name, int use_of_water, int time_delay, string plant_description, string url, int hydration_needed)
        {
            this.Id = id;
            this.Plant_name = plant_name;
            this.Use_of_water = use_of_water;
            this.Time_delay = time_delay;
            this.Plant_description = plant_description;
            this.Url = url;
            this.Hydration_needed = hydration_needed;
            
        }
       
    }
}
