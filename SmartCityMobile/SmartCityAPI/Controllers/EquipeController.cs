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
    public class EquipeController : ControllerBase
    {
        private Db2020PPE3DevoilleContext context;

        public EquipeController()
        {
            context = new Db2020PPE3DevoilleContext();
        }

        // GET: api/<ConnexionController>
        [HttpGet]
        public IActionResult Get([FromQuery] string id)
        {
            var appartenir = context.Appartenirs.Where(a => a.IdJoueur == int.Parse(id));
            var equipe = context.Equipes.Where(e => appartenir.Any(a => a.IdEquipe == e.Id));
            return Ok(equipe);
        }

        // GET api/<EquipeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EquipeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EquipeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EquipeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
