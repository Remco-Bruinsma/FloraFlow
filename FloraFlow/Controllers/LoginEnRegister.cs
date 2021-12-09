using FloraFlow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FloraFlow.Controllers
{
    public class LoginEnRegister : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<ActionResult> SignIn(User obj)
        {
            //sign in and redirect to home page
            string UserId = obj.UserId;
            string password = obj.Password;
            var loginkeys = new Dictionary<string, string>
            {
                { "Userid", ""+UserId+"" },
                { "password", ""+password+"" }
            };
            var content = new FormUrlEncodedContent(loginkeys);
            var response = await client.PostAsync("https://localhost:44350/code", content);
            var responseString = await response.Content.ReadAsStringAsync();
            if (responseString == "0") 
            {
                return View("~/Views/LoginEnRegister/Inlog.cshtml");
            }
            else
            {
                TempData["key"] = responseString;
                return RedirectToAction("Pots2", "Pots", new { area = "" });
            }
            

            
        }
    }
}
