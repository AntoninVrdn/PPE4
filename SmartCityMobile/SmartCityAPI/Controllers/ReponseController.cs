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
    public class ReponseController : ControllerBase
    {
        private Db2020PPE3DevoilleContext context;

        public ReponseController()
        {
            context = new Db2020PPE3DevoilleContext();
        }

        // GET: api/<ConnexionController>
        [HttpGet]
        public IActionResult Get([FromQuery]int idQuestion)
        {
            var reponses = context.Reponses.FirstOrDefault(r => r.IdQuestion == idQuestion);
            return Ok(reponses);
        }


        // POST api/<ReponseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReponseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReponseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
