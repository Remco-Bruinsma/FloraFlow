
using FloraFlow.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        private IActionResult pots()
        {
            if (Request.Cookies["UserId"] != null & Request.Cookies["password"] != null)
            {
                return RedirectToAction("Getuserpots", "Pots", new { area = "" });
            }
            else
            {
                return RedirectToAction("CookiesDeleter", "LoginEnRegister", new { area = "" });
            }

        }
        public IActionResult Pots()
        {
            return pots();

        }
        //here i fill in my new pots 
        private IActionResult fillPot(PlantModel plant)
        {
            return RedirectToAction("Pots", "Pots", new { area = "" });

        }
        public IActionResult FillPot(PlantModel plant)
        {
            return fillPot(plant);

        }
        //here i cahnge my pots based on the input of the buttons  
        private IActionResult changePot(int pot)
        {
            if (Request.Cookies["UserId"] != null & Request.Cookies["password"] != null)
            {
                ViewData["pot"] = pot;
                TempData["pot"] = pot;
                return RedirectToAction("Plants", "Plants", new { area = "" });

            }
            else
            {
                return RedirectToAction("CookiesDeleter", "LoginEnRegister", new { area = "" });

            }

        }
        public IActionResult ChangePot(int pot)
        {
            return changePot(pot);

        }

        private async Task<IActionResult> removePot(int pot)
        {
            if (Request.Cookies["UserId"] != null & Request.Cookies["password"] != null)
            {
                string UserId = Request.Cookies["Userid"];
                string password = Request.Cookies["password"];
                string removepot = pot.ToString();
                var loginkeys = new Dictionary<string, string>
                {
                    { "Userid", ""+UserId+"" },
                    { "password", ""+password+"" },
                    {"removedpot",""+removepot+"" }
                };
                var content = new FormUrlEncodedContent(loginkeys);
                var response = await client.PostAsync($"https://localhost:44350/removepots", content);
                var responseString = await response.Content.ReadAsStringAsync();
                return RedirectToAction("Pots", "Pots", new { area = "" });

            }
            else
            {
                return RedirectToAction("CookiesDeleter", "LoginEnRegister", new { area = "" });
            }

        }
        public async Task<IActionResult> RemovePot(int pot)
        {
            return await removePot(pot);

        }
        private async Task<IActionResult> addpot()
        {
            string UserId = Request.Cookies["Userid"];
            string password = Request.Cookies["password"];

            var loginkeys = new Dictionary<string, string>
            {
                { "Userid", ""+UserId+"" },
                { "password", ""+password+"" }
            };
            var content = new FormUrlEncodedContent(loginkeys);
            var response = await client.PostAsync($"https://localhost:44350/addpots", content);
            var responseString = await response.Content.ReadAsStringAsync();
            return RedirectToAction("Pots", "Pots", new { area = "" });

        }
        public async Task<IActionResult> Addpot()
        {
            return await addpot();

        }
        private IActionResult applypot()
        {
            return View("~/Views/Pots/Pots.cshtml");

        }
        public IActionResult Applypot()
        {
            return applypot();

        }

        private static readonly HttpClient client = new HttpClient();
        private async Task<IActionResult> getuserpots()
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
        public async Task<IActionResult> Getuserpots()
        {
            return await getuserpots();

        }
    }
}
