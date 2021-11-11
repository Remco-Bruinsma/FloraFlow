using FloraFlow.Classes;
using FloraFlow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow.Controllers
{
    public class PlantsController : Controller
    {
        public IActionResult Plants()
        {
            List<PlantModel> plants = new List<PlantModel> { };
            List<string> plantNames = ImportPlants.ImportPlantNames();
            List<string> plantImages = ImportPlants.ImportPlantImg();
            for (int i = 0; i < plantNames.Count(); i++)
            {
                PlantModel plantModel = new PlantModel {Plant_name = plantNames[i], Url = plantImages[i] };
                plants.Add(plantModel);
            }
            ViewData["plants"] = plants;
            return View("~/Views/Plants/Plants.cshtml", plants);
        }
    }
}