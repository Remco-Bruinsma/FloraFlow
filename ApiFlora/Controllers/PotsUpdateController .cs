using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using ApiFlora.Class;

namespace ApiFlora.Controllers
{
    public class PotsUpdateController : Controller
    {
      
        [HttpPost("UpdatePot")]
        public IActionResult UpdatePot(Dictionary<string, string> results)
        { 
            return Ok(UpdatePlant.InPot(results["plant"], results["pot"]));
        }

    }
}
