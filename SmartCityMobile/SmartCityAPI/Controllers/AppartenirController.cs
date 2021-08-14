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
    public class AppartenirController : ControllerBase
    {
        private Db2020PPE3DevoilleContext context;

        public AppartenirController()
        {
            context = new Db2020PPE3DevoilleContext();
        }

        // GET: api/<ConnexionController>
        [HttpGet]
        public IActionResult Get()
        {
            var appartenir = context.Appartenirs;
            return Ok(appartenir);
        }

        // GET api/<AppartenirController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AppartenirController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AppartenirController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AppartenirController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
