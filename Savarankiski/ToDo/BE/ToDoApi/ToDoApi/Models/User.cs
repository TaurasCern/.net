namespace ToDoApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<ToDoNote> ToDoNotes { get; set; } = new HashSet<ToDoNote>();
    }
}
