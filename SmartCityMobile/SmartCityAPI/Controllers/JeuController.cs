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
    public class JeuController : ControllerBase
    {
        private Db2020PPE3DevoilleContext context;

        public JeuController()
        {
            context = new Db2020PPE3DevoilleContext();
        }

        // GET: api/<ConnexionController>
        [HttpGet]
        public IActionResult Get() //[FromQuery] int Id
        {
            //List<Jouer> jouers = new List<Jouer>();
            //List<Jeu> jeux = new List<Jeu>();
            //var test = context.Appartenirs;
            //var appartenirs = context.Appartenirs.Where(appartenir => appartenir.IdJoueur == Id);
            //foreach (var item in appartenirs)
            //{
            //    var jouer = context.Jouers.FirstOrDefault(jouer => jouer.IdEquipe == item.IdEquipe);
            //    jouers.Add(jouer);
            //}

            //foreach (var item in jouers)
            //{
            //    var jeu = context.Jeus.FirstOrDefault(jeu => jeu.Id == item.IdJeux);
            //    jeux.Add(jeu);
            //}
            var jeux = context.Jeus;
            return Ok(jeux);
        }

        

        // POST api/<JeuController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JeuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JeuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
