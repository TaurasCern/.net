using ToDoApi.DTOs;

namespace ToDoApi.Models
{
    public class User
    {
        public User()
        {

        }
        public User(UserDTO user)
        {
            Email = user.Email;
            Password = user.Password;
            FirstName = user.FirstName;
            LastName = user.LastName;
        }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<ToDoNote> ToDoNotes { get; set; } = new HashSet<ToDoNote>();
    }
}
