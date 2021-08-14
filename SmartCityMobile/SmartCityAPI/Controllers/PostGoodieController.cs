using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SmartCityApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartCityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostGoodieController : ControllerBase
    {
        private Db2020PPE3DevoilleContext context;

        public PostGoodieController()
        {
            context = new Db2020PPE3DevoilleContext();
        }

        // GET: api/<ConnexionController>
        [HttpGet]
        public IActionResult Get([FromQuery] string idG, [FromQuery] string idE )
        {
            SqlConnection con = new SqlConnection("Data Source=srvantonine4.database.windows.net,1433;Initial Catalog=E4Antonin;Persist Security Info=True;User ID=antoninE4;Password=Azerty@123");
            con.Open();
            SqlCommand command = new SqlCommand(null, con);

            command.CommandText =
                    "INSERT INTO EQUIPE_GOODIE (ID_EQUIPE, ID_GOODIES) " +
                    "VALUES (@idE, @idG)";
            SqlParameter idEparam = new SqlParameter("@idE", SqlDbType.Int, 0);
            SqlParameter idGparam = new SqlParameter("@idG", SqlDbType.Int, 0);

            idEparam.Value = int.Parse(idE);
            idGparam.Value = int.Parse(idG);

            command.Parameters.Add(idEparam);
            command.Parameters.Add(idGparam);

            command.Prepare();
            command.ExecuteNonQuery();

            return Ok();
        }
    

      

        // POST api/<PostGoodieController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PostGoodieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostGoodieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
