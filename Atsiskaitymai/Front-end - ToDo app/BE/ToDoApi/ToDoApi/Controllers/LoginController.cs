using Microsoft.AspNetCore.Mvc;
using ToDoApi.Database;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApiContext _context;

        public LoginController(ApiContext context)
        {
            _context = context;
        }
        [HttpPost("/login")]
        public JsonResult Login(LoginInfo info)
        {
            var user = _context.Users
                .Where(u => u.Email == info.Email)
                .FirstOrDefault();

            if (user == null) return new JsonResult(NotFound());

            if (user.Password == info.Password) 
                return new JsonResult(Ok(new { id = user.UserId, toDoNotes = user.ToDoNotes, name = $"{user.FirstName} {user.LastName}" }));
            else 
                return new JsonResult(NotFound());
        }
    }
}
