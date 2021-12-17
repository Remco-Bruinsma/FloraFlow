using FloraFlow.Models;
using Microsoft.AspNetCore.Http;
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
            string UserId = Request.Cookies["Userid"];
            string password = Request.Cookies["password"];

            var loginkeys = new Dictionary<string, string>
            {
                { "Userid", ""+UserId+"" },
                { "password", ""+password+"" }
            };
            var content = new FormUrlEncodedContent(loginkeys);
            var response = await client.PostAsync("https://localhost:44350/code", content);
            var responseString = await response.Content.ReadAsStringAsync();
            if (responseString == "Wrong Username or Password")
            {
                return View("~/Views/LoginEnRegister/Inlog.cshtml");
            }
            
            else if (responseString =="Right Username or Password")
            {
                
                return RedirectToAction("Getuserpots", "Pots", new { area = "" });
            }
            else
            {
                Console.WriteLine("Error 404");
                return View("~/Views/LoginEnRegister/Inlog.cshtml");

            }
           

        }
        [HttpPost]
        public IActionResult Cookies(User obj)
        {
            string UserId = obj.UserId;
            string password = obj.Password;
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Append("Userid", UserId,options);
            Response.Cookies.Append("password", password, options);

            return RedirectToAction("SignIn", "LoginEnRegister",new { area = "" });
        }
        public async Task<IActionResult> Register(User obj)
        {
            string reUserId = obj.UserId;
            string repassword = obj.Password;

            var loginkeys = new Dictionary<string, string>
            {
                { "reUserid", ""+reUserId+"" },
                { "repassword", ""+repassword+"" }
            };
            var content = new FormUrlEncodedContent(loginkeys);
            var response = await client.PostAsync($"https://localhost:44350/addaccount", content);
            var responseString = await response.Content.ReadAsStringAsync();

            return RedirectToAction("SignIn", "LoginEnRegister", new { area = "" });
        }

        public IActionResult CookiesDeleter()
        {
            Response.Cookies.Delete("Userid");
            Response.Cookies.Delete("password");
            return View("~/Views/LoginEnRegister/Inlog.cshtml");
           
        }
        public IActionResult Logout()
        {
            Response.Cookies.Delete("Userid");
            Response.Cookies.Delete("password");
            return View("~/Views/LoginEnRegister/Inlog.cshtml");
        }
        
        public IActionResult ToRegisterView()
        {
            return View("~/Views/LoginEnRegister/register.cshtml");
        }


    }
}
