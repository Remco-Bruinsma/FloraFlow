
using FloraFlow.Models;
using Microsoft.AspNetCore.Mvc;
using PlantJson_QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FloraFlow.Controllers
{
    public class PlantsController : Controller
    {
     
        private IActionResult plants()
        {
            using (var webClient = new WebClient())
            {
                string jsonString = webClient.DownloadString("https://localhost:44350/api/Plants");
                var plantsjson = PlantsJson.FromJson(jsonString);
                /*TempData["plantJson"] = plantsjson;*/
                ViewData["plantJson"] = plantsjson;
               
            }
            
            return View("~/Views/Plants/Plants.cshtml");

        }
        public IActionResult Plants()
        {
            return plants();

        }
        private IActionResult changeplants(int plant)
        {
            ViewData["plant"] = plant;
            TempData["plant"] = plant;
            return RedirectToAction("UpdatePot", "AsignPlant", new { area = "" });

        }
        public IActionResult Changeplants(int plant)
        {
            return changeplants(plant);

        }

    }
}