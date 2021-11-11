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
            List<PlantModel> plantsName = new List<PlantModel> { };
            List<string> plantNames = ImportPlants.ImportPlantNames();
            ViewData["plants"] = plantNames;
            return View("~/Views/Plants/Plants.cshtml", plantsName);

            List<PlantModel> plantsImg = new List<PlantModel> { };
            List<string> plantImages = ImportPlants.ImportPlantImg();
            ViewData["plants"] = plantImages;
            return View("~/Views/Plants/Plants.cshtml", plantsImg);
        }
    }
}