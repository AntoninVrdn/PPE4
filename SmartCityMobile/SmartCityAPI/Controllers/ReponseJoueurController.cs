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
    public class ReponseJoueurController : ControllerBase
    {
        private Db2020PPE3DevoilleContext context;

        public ReponseJoueurController()
        {
            context = new Db2020PPE3DevoilleContext();
        }

        // GET: api/<ConnexionController>
        [HttpGet]
        public IActionResult Get([FromQuery]string reponse, [FromQuery]string id)
        {

            var rep = context.Reponses.FirstOrDefault(r => r.Intitule == reponse && r.IdQuestion == int.Parse(id));

            return Ok(rep);
        }

        // GET api/<ReponseJouerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReponseJouerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReponseJouerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReponseJouerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
