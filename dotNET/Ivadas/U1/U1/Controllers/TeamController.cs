using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using U1.Models.DTO;

namespace U1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        [HttpGet]
        public TeamDTO Get()
        {
            return Data.Teams.teamList[0];
        }
    }
}
