using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using FloraFlow.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FloraFlow.Controllers
{
    public class AsignPlantController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> UpdatePot()
        {
            int pot = (int)TempData["pot"];
            int plant = (int)TempData["plant"];
            var PotAndPlant = new Dictionary<string, string>
            {
                { "plant", ""+plant+"" },
                { "pot", ""+pot+"" }
            };
            var content = new FormUrlEncodedContent(PotAndPlant);
            var response = await client.PostAsync("https://localhost:44350/UpdatePot", content);
            var responseString = await response.Content.ReadAsStringAsync();
            return RedirectToAction("Getuserpots", "Pots", new { area = "" });
        }
    }
}
