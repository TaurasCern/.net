using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApi.Database;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApiContext _context;

        public UserController(ApiContext context)
        {
            _context = context;
        }

        [HttpPost]
        public JsonResult Post(User user)
        {
            if (user.ToDoNotes != null) return new JsonResult(BadRequest(user));

            if(_context.Users.Where(u => u.Email == user.Email).FirstOrDefault() != null) return new JsonResult(BadRequest(new {reason = "Already exists"}));

            _context.Users.Add(user);

            _context.SaveChanges();

            return new JsonResult(Ok(new { id = user.UserId, name = $"{user.FirstName} {user.LastName}" }));
        }
        [HttpGet]
        public JsonResult GetAll()
        {
            return new JsonResult(_context.Users);
        }
    }
}
