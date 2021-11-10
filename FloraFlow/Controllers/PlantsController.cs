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
            ViewData["plants"] = plantNames;
            return View("~/Views/Plants/Plants.cshtml", plants);
        }
    }
}
