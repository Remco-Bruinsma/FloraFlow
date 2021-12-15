using ApiFlora.Class;
using ApiFlora.Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlora.Controllers
{
    public class UserCheckController : Controller
    {
        [HttpPost("code")]
        public IActionResult GiveCode(Dictionary<string, string> results)
        {
            return Ok(UserCode.User(results, true));
        }
        
    }
}
