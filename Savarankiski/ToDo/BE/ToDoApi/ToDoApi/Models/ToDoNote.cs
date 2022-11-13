namespace ToDoApi.Models
{
    public class ToDoNote
    {
        public int NoteId { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public DateTime EndDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
