using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MagicCalendar.Models
{
    public class Format
    {
        [Key]
        public int FormatID { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public Game Game { get; set; }

        [DisplayName("Number of Players Per Team")]
        public int? NumberOfPlayersPerTeam { get; set; } 
    }
}