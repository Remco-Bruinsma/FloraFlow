using ApiFlora.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiFlora.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PotsController : ControllerBase
    {
        public List<PotsModel> pots = new List<PotsModel>();
        public List<PlantModel> plants = new List<PlantModel>();
        public List<PotsModel> userpots = new List<PotsModel>();

        public PotsController()
        {
            plants = ImportPlants.PlantClassListMaker();
            pots = ImportPots.PotsClassListMaker(plants,Querys.AllPots());

        }

        [HttpGet]
        public List<PotsModel> Get()
        {
            return pots;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{Pot_ID}")]
        public PotsModel Get(int Pot_ID)
        {
            return (PotsModel)pots.Where(x => x.Pot_ID == Pot_ID).FirstOrDefault();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] PotsModel val)
        {
            pots.Add(val);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{Id}")]
        public void Put(int Id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{Id}")]
        public void Delete(int id)
        {

        }
        
    }
}
