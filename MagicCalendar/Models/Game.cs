using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MagicCalendar.Models
{
    public class Game
    {
        [Key]
        public int GameID { get; set; }
        [DisplayName("Game Name")]
        public string GameName { get; set; }
        public string Publisher { get; set; }
    }
}