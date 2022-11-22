using U1.Models.DTO;

namespace U1.Data
{
    public class Teams
    {
        public static List<TeamDTO> teamList = new List<TeamDTO>()
        {
            new TeamDTO(1,"a", Athletes.athleteList),
        };
    }
}
