using FloraFlow.Classes;
using FloraFlow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow.Controllers
{
    public class PotsController : Controller
    {
        public IActionResult Pots()
        {
            List<Potmodel> potsName = new List<Potmodel> { };
            List<string> potsNames = ImportPots.ImportPlantNames();
            ViewData["pots"] = potsNames;
            return View("~/Views/Pots/Pots.cshtml", potsName);

            List<Potmodel> potsImg = new List<Potmodel> { };
            List<string> potsImages = ImportPots.ImportPlantImg();
            ViewData["pots"] = potsImages;
            return View("~/Views/Pots/Pots.cshtml", potsImg);
            
        }
      /*  [HttpPost]
        public ActionResult Index(string button)
        {
            if (button.ToLower() == "login")
            {
                // Do your Stuff.
            }
            else if (button.ToLower() == "cancel")
            {
                // Do your Stuff.
            }
            return View();
        }*/
        
    }
}
