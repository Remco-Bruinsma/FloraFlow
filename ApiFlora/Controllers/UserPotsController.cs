using ApiFlora.Class;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlora.Controllers
{
    public class UserPotsController : Controller
    {
        [HttpPost("getuserspots")]
        public IActionResult GetUsersPots(string UserId, Dictionary<string, string> results)
        {
            List<PlantModel> plants = ImportPlants.PlantClassListMaker();
            UserCode.User(results, false);
            List<PotsModel>userpots = ImportPots.PotsClassListMaker(plants, Querys.UserPots(UserCode.User(results, false)));
            return Ok(userpots);
        }
    }
}
