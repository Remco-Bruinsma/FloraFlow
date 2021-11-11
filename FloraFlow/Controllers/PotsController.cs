using FloraFlow.Classes;
using FloraFlow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraFlow.Controllers
{
    public class PotsController : Controller
    {

        public IActionResult Pots()
        {
            List<Potmodel> pots = new List<Potmodel> { };
            List<string> potsNames = DbClass.GetFromDb("SELECT `ID` FROM `pots`");
            PlantModel plant = new PlantModel { Plant_name = "FlamingoPlant", Url = "https://cdn.webshopapp.com/shops/29478/files/360280714/650x650x2/citroenboom.jpg" };
            foreach (string pot in potsNames)
            {
                Potmodel Pot = new Potmodel { ID = Convert.ToInt32(pot), Amount = 1, Plant = plant };
                pots.Add(Pot);
            }
            ViewData["pots"] = pots;
            return View("~/Views/Pots/Pots.cshtml");

        }
        public IActionResult FillPot(string plant)
        {
            int pot = (int)TempData["pot"];
            List<string> plantId = DbClass.GetFromDb("SELECT id FROM `plants` WHERE `plantName` LIKE '" + plant + "'");
            DbClass.StoreDb("UPDATE `pots` SET `plant` = '" + plantId[0] + "' WHERE `pots`.`ID` = " + pot + ";");
            return RedirectToAction("Pots", "Pots", new { area = "" });
        }
        public IActionResult ChangePot(int pot)
        {
            ViewData["pot"] = pot;
            TempData["pot"] = pot;
            return RedirectToAction("Plants", "Plants", new { area = "" });
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
