using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiFlora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        // GET: api/<ValuesController>
        
        List<PlantModel> plants = new List<PlantModel>();
        public PlantsController()
        {
            plants = ImportPlants.PlantClassListMaker();

        }
        [HttpGet]
        public List<PlantModel> Get()
        {
            return plants;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{Plant_name}")]
        public PlantModel Get(string Plant_name)
        {
            return plants.FirstOrDefault(x => x.Plant_name == Plant_name);
        }

        // POST api/<ValuesController>
        [HttpPost("post")]
        public void Post([FromBody] PlantModel val)
        {
            plants.Add(val);
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
