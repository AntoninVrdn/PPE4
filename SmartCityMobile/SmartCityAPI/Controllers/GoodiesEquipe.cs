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
    public class GoodiesEquipe : ControllerBase
    {
        private Db2020PPE3DevoilleContext context;

        public GoodiesEquipe()
        {
            context = new Db2020PPE3DevoilleContext();
        }

        // GET: api/<ConnexionController>
        [HttpGet]
        public IActionResult Get([FromQuery] int id)
        {
            var equipegoodies = context.EquipeGoodies.Where(e => e.IdEquipe == id);
            var goodies = context.Goodies.Where(g => equipegoodies.Any(e => e.IdGoodies == g.Id));
            return Ok(goodies);
        }

        

        // POST api/<GoodiesEquipe>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GoodiesEquipe>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GoodiesEquipe>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
