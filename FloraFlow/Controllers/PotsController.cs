using FloraFlow.Classes;
using FloraFlow.Models;
using Microsoft.AspNetCore.Mvc;
using QuickType2;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FloraFlow.Controllers
{
    public class PotsController : Controller
    {
        public int potid;

       
        public IActionResult Pots()
        {
            using (var webClient = new WebClient())
            {
                string jsonString = webClient.DownloadString("https://localhost:44350/api/Pots");
                var potsjson = PotsJson.FromJson(jsonString);
                ViewData["potsJson"] = potsjson;
                
            }
           /* //her i use the methode dbclass to retreave the id of the plant in the pots
            List<Potmodel> pots = new List<Potmodel> { };
            List<string> potIDs = DbClass.GetFromDb("SELECT `pot_id` FROM `pots`");
            //here i get my pots from mysql
            foreach ( string pot in potIDs)
            {
                List<string> plantID = DbClass.GetFromDb("SELECT `plant` FROM `pots` WHERE `pot_id` = '"+pot+"'");
                List<string> plant = DbClass.GetFromDb("SELECT * FROM `plants` WHERE `id` = "+plantID[0]+"");
                PlantModel plantModel = new PlantModel { Plant_name = plant[1],Url = plant[5]};
                Potmodel Pot = new Potmodel { Pot_ID = Convert.ToInt32(pot), Amount = 1, Plant = plantModel };
                pots.Add(Pot);
            }
            ViewData["pots"] = pots;*/
           
            return View("~/Views/Pots/Pots.cshtml");

        }
        //here i fill in my new pots 
        public IActionResult FillPot(PlantModel plant)
        {
            
          /*  int pot = (int)TempData["pot"];
            *//*List<string> plantId = DbClass.GetFromDb("SELECT id FROM `plants` WHERE `id` LIKE '" + plant + "'");*//*
            DbClass.StoreDb("UPDATE `pots` SET `plant` = '" + plant + "' WHERE `pots`.`pot_id` = " + pot + ";");*/
           
            return RedirectToAction("Pots", "Pots", new { area = "" });
        }
        //here i cahnge my pots based on the input of the buttons  
        public IActionResult ChangePot(int pot)
        {
            
            ViewData["pot"] = pot;
            TempData["pot"] = pot;
            return RedirectToAction("Plants","Plants", new { area = "" });
        }
        public IActionResult Addpot( )
        {
            return View("~/Views/Pots/AddPots.cshtml");
        }
        public IActionResult Applypot()
        {

            return View("~/Views/Pots/Pots.cshtml");
        }
        
    }
}
