using Microsoft.AspNetCore.Mvc;
using SmartCityApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartCityAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConnexionController : ControllerBase
    {
        private Db2020PPE3DevoilleContext context;

        public ConnexionController()
        {
            context = new Db2020PPE3DevoilleContext();
        }

        // GET: api/<ConnexionController>
        [HttpGet]
        public IActionResult Get([FromQuery] string login, [FromQuery] string mdp)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(mdp)) return BadRequest();
            var joueur = context.Joueurs.FirstOrDefault(joueur => joueur.Username == login && joueur.Password == mdp);
            if (joueur == null) return NotFound();

            return Ok(joueur);
            //{
            //    Status = "200",
            //    Joueur = new
            //    {
            //        Id = joueur.Id,
            //        Games = context.Appartenirs.Where(appartenir => appartenir.IdJoueur == joueur.Id)
            //                                            .SelectMany(appartenir => appartenir.Equipe.Jouers)
            //                                            .Select(jouer => new { Id = jouer.IdJeux, IdRoute = jouer.Jeux.IdRoute, TempsFinal = jouer.Jeux.Tempsfinal, Scorefinal = jouer.Jeux.Scorefinal, Datecreation = jouer.Jeux.Datecreation })
            //        Equipes = new { uri = Request.Scheme + "://" + Request.Host + "/api/Joueurs/" + joueur.Id + "/Equipes" }
            //    }
            //});



            //return Ok(games);
        }

        // GET api/<ConnexionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ConnexionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ConnexionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConnexionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
