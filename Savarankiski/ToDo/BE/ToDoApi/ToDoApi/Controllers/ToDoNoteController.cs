using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoApi.Database;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoNoteController : ControllerBase
    {
        private readonly ApiContext _context;
        public ToDoNoteController(ApiContext context)
        {
            _context = context;
        }
        [HttpPost]
        public JsonResult Get(ToDoNote note)
        {
            var user = _context.Users.Find(note.UserId);
        
            if (user == null) return new JsonResult(NotFound());
        
            user.ToDoNotes.Add(note);
        
            _context.SaveChanges();
        
            return new JsonResult(Ok(note));
        }
        [HttpGet]
        public JsonResult Get(int userId)
        {
            var user = _context.Users
                .Where(x => x.UserId == userId)
                .Include(u => u.ToDoNotes)
                .FirstOrDefault();
        
            if (user == null) return new JsonResult(NotFound());

            var notes = user.ToDoNotes;   
        
            return new JsonResult(Ok(new 
            { 
                firstName = user.FirstName, 
                lastName = user.LastName,
                toDoNotes = notes
            }));
        }
        [HttpPut]
        public JsonResult Put(ToDoNote note)
        {
            if (note == null) return new JsonResult(BadRequest());

            var foundNote = _context.ToDoNotes.Find(note.NoteId);

            if (foundNote == null) return new JsonResult(BadRequest());

            foundNote.Type = note.Type;
            foundNote.Content = note.Content;
            foundNote.EndDate = note.EndDate;

            _context.SaveChanges();

            return new JsonResult(Ok(note));
        }
        [HttpDelete]
        public JsonResult Delete(int noteId)
        {
            var note = _context.ToDoNotes.Find(noteId);

            if (note == null) return new JsonResult(NotFound());

            _context.ToDoNotes.Remove(note);

            _context.SaveChanges();

            return new JsonResult(Ok(note));             
        }
    }
}
