namespace ToDoApi.DTOs
{
    public class ToDoNoteDTO
    {
        public int NoteId { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public DateTime EndDate { get; set; }

        public int UserId { get; set; }
    }
}
