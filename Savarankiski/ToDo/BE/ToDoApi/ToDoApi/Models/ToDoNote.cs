using ToDoApi.DTOs;

namespace ToDoApi.Models
{
    public class ToDoNote
    {
        public ToDoNote()
        {

        }
        public ToDoNote(ToDoNoteDTO note)
        {
            Type = note.Type;
            Content = note.Content;
            EndDate = note.EndDate;
            UserId = note.UserId;
        }

        public int NoteId { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public DateTime EndDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
