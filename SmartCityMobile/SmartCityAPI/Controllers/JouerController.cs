using Microsoft.AspNetCore.Mvc;
using SmartCityApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartCityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JouerController : ControllerBase
    {

        private Db2020PPE3DevoilleContext context;

        public JouerController()
        {
            context = new Db2020PPE3DevoilleContext();
        }
        // GET: api/<JouerController>
        [HttpGet]
        public IActionResult Get()
        {
            var jouer = context.Jouers;
            return Ok(jouer);
        }

        // GET api/<JouerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JouerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JouerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JouerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
