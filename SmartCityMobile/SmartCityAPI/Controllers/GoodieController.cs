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
    public class GoodieController : ControllerBase
    {
        private Db2020PPE3DevoilleContext context;

        public GoodieController()
        {
            context = new Db2020PPE3DevoilleContext();
        }

        // GET: api/<ConnexionController>
        [HttpGet]
        public IActionResult Get([FromQuery]int Score) 
        {
            var goodies = context.Goodies.Where(g => g.Points <= Score);
            return Ok(goodies);
        }

 
        // POST api/<GoodieController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GoodieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GoodieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
