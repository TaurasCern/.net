namespace U1.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Athlete> Athletes { get; set; }
    }
}
