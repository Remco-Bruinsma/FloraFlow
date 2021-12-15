using FloraFlow.Classes;
using FloraFlow.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PotJson_QuickType;
using UserPotModel_QuickType;
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

        public IActionResult Pots()
        {


            if (Request.Cookies["UserId"] != null & Request.Cookies["password"] != null)
            {
                return RedirectToAction("Getuserpots", "Pots", new { area = "" });
            }
            else
            {
                return View("~/Views/LoginEnRegister/Inlog.cshtml");
            }


        }
        //here i fill in my new pots 
        public IActionResult FillPot(PlantModel plant)
        {

            return RedirectToAction("Pots", "Pots", new { area = "" });
        }
        //here i cahnge my pots based on the input of the buttons  
        public IActionResult ChangePot(int pot)
        {

            if(Request.Cookies["UserId"] != null & Request.Cookies["password"] != null)
            {
                ViewData["pot"] = pot;
                TempData["pot"] = pot;
                return RedirectToAction("Plants", "Plants", new { area = "" });
                
            }
            else
            {

                return View("~/Views/LoginEnRegister/Inlog.cshtml");

            }
           
        }
        public IActionResult Addpot()
        {
            return View("~/Views/Pots/AddPots.cshtml");
        }
        public IActionResult Applypot()
        {

            return View("~/Views/Pots/Pots.cshtml");
        }
        public IActionResult Pots2()
        {
            using (var webClient = new WebClient())
            {
                if (Request.Cookies["UserId"] != null & Request.Cookies["password"] != null)
                {
                    return RedirectToAction("Getuserpots", "Pots", new { area = "" });
                }
                else
                {
                    return View("~/Views/LoginEnRegister/Inlog.cshtml");
                }

            }

        }
        private static readonly HttpClient client = new HttpClient();
        public async Task<IActionResult> Getuserpots()
        {
            string UserId = Request.Cookies["Userid"];
            string password = Request.Cookies["password"];

            var loginkeys = new Dictionary<string, string>
            {
                { "Userid", ""+UserId+"" },
                { "password", ""+password+"" }
            };
            var content = new FormUrlEncodedContent(loginkeys);
            var response = await client.PostAsync($"https://localhost:44350/getuserspots", content);
            var responseString = await response.Content.ReadAsStringAsync();
            var newuserpotmodel = UserPotModel.FromJson(responseString);
            List<UserPotModels> userpots = new List<UserPotModels>();
            userpots.AddRange(newuserpotmodel);
            if (userpots != null)
            {
                ViewData["userpot"] = userpots;
                return View("~/Views/Pots/Pots.cshtml");
            }
            else
            {
                return RedirectToAction("CookiesDeleter", "LoginEnRegister", new { area = "" });
            }
            
            
            

            

            
        }
    }
}
