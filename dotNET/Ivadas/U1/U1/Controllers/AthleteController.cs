using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using U1.Models;
using U1.Models.DTO;

namespace U1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AthleteController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(AthleteDTO))] // same as StatusCodes.Status200OK
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<AthleteDTO?> Get(int id)
        {
            if (id == 0) return BadRequest();

            var athlete = Data.Athletes.athleteList.FirstOrDefault(a => a.Id == id);

            if (athlete == null) return NotFound();

            return Ok(athlete);
        }
    }
}
