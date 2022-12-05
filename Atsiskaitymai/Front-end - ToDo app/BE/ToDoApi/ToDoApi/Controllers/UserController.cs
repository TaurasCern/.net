using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApi.Database;
using ToDoApi.DTOs;
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
        public JsonResult Post(UserDTO user)
        {
            if(_context.Users.Where(u => u.Email == user.Email).FirstOrDefault() != null) return new JsonResult(BadRequest(new {reason = "Already exists"}));

            var newUser = new User(user);

            _context.Users.Add(newUser);

            _context.SaveChanges();
            return new JsonResult(Ok(new { id = newUser.UserId, name = $"{newUser.FirstName} {newUser.LastName}" }));
        }
        [HttpGet]
        public JsonResult GetAll()
        {
            return new JsonResult(_context.Users);
        }
    }
}
