namespace DataReading.Domain.Models
{
    public class BasicUser
    {
        public BasicUser() { }
        public BasicUser(string[] userData)
        {
            Id = Convert.ToInt32(userData[0]);
            Name = userData[1];
        }
        public BasicUser(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}