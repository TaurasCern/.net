namespace U1.Models.DTO
{
    public class TeamDTO
    {
        public TeamDTO(int id, string name, List<AthleteDTO> athletes)
        {
            Id = id;
            Name = name;
            Athletes = athletes;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<AthleteDTO> Athletes { get; set; }
    }
}
