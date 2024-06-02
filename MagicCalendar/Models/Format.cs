namespace MagicCalendar.Models
{
    public class Format
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Game Game { get; set; }
        
        public int? NumberOfPlayersPerTeam { get; set; } 

        public Boolean IsTeamBased { get; set; }
    }
}