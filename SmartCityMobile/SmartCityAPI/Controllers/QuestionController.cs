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
    public class QuestionController : ControllerBase
    {

        private Db2020PPE3DevoilleContext context;

        public QuestionController()
        {
            context = new Db2020PPE3DevoilleContext();
        }

        // GET: api/<QuestionController>
        [HttpGet]
        public IActionResult Get([FromQuery]int ID)
        {
            List<dynamic> test = new List<dynamic>();
            var questions = context.Questions.Where(q => q.IdMission == ID);
            foreach (var item in questions)
            {
                
                //context.Reponses.FirstOrDefault(r => r.Id == item.IdBonneReponse);
                   
            }
            test.Add(questions);
            return Ok(questions);
        }

        // GET api/<QuestionController>/5
        

        // POST api/<QuestionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QuestionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuestionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
