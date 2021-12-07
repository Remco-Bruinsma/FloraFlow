using FloraFlow.Classes;
using FloraFlow.Models;
using Microsoft.AspNetCore.Mvc;
using QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FloraFlow.Controllers
{
    public class PlantsController : Controller
    {
     
        public IActionResult Plants()
        {
            using (var webClient = new WebClient())
            {
                string jsonString = webClient.DownloadString("https://localhost:44350/api/Plants");
                var plantsjson = PlantsJson.FromJson(jsonString);
                /*TempData["plantJson"] = plantsjson;*/
                ViewData["plantJson"] = plantsjson;
               
            }
            /*  //here i fill in my classmodel and put those in a list 
              List<PlantModel> plants = new List<PlantModel> { };
              // the names and images  i get by importing them fom mysql useing the methodes from the class impotplants 
              List<string> plantNames = ImportPlants.ImportPlantNames();
              List<string> plantImages = ImportPlants.ImportPlantImg();
              // and here is a loop for the lenght of sql  
              for (int i = 0; i < plantNames.Count(); i++)
              {
                  //hier in gebruik ik me plantmodel en vul ik die als list
                  PlantModel plantModel = new PlantModel { Plant_name = plantNames[i], Url = plantImages[i] };
                  plants.Add(plantModel);
              }*/
            //return as plants and redirect plants page 
            /*ViewData["plants"] = plants;
            TempData["plants"] = plants;*/
            return View("~/Views/Plants/Plants.cshtml");



        }
        [HttpGet("api/changeplant")]
        public List<changepotmodel> Get()
        {
           
            List<changepotmodel> change = new List<changepotmodel>();
            changepotmodel chpo = new changepotmodel();
            chpo.Usedpot= (int)TempData["pot"];
            chpo.Usedplant = (int)TempData["plant"];
          

            change.Add(chpo);
            return change;
        }
        /*[HttpGet("api/changeplant")]
        public List<Potmodel> Get(PlantModel plant)
        {
            List<PlantModel> pla = new List<PlantModel>();
            var plantsJsons = (PlantsJson[])TempData["plantJson"];
            int plantid = Convert.ToInt32(TempData["plant"]);
            foreach (PlantsJson plantsJson in plantsJsons)
            {
                if (plantsJson.Id == plantid)
                {
                    pla.Clear();
                    PlantModel pl = new PlantModel();
                    pl.Id = Convert.ToInt32(plantsJson.Id);
                    pl.Plant_name = plantsJson.PlantName.ToString();
                    pl.Use_of_water = Convert.ToInt32(plantsJson.UseOfWater);
                    pl.Time_delay = Convert.ToInt32(plantsJson.TimeDelay);
                    pl.Plant_description = plantsJson.PlantDescription.ToString();
                    pl.Url = plantsJson.Url.ToString();
                    pl.Hydration_needed = Convert.ToInt32(plantsJson.HydrationNeeded);
                    pla.Add(pl);
                }
            }
            int changeid = Convert.ToInt32(TempData["plant"]);
            List<Potmodel> pots = new List<Potmodel>();
            Potmodel po = new Potmodel();
            po.Pot_ID = (int)TempData["pot"];
            po.Amount = 1;
            po.Plant = pla[0];
            po.Soil_hydration = 0;

            pots.Add(po);



            return pots;
        }*/
        public IActionResult Changeplants(int plant)
        {

            ViewData["plant"] = plant;
            TempData["plant"] = plant;
            return RedirectToAction("Pots", "Pots", new { area = "" });
        }

    }
}