using System.ComponentModel.DataAnnotations;

namespace MagicCalendar.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
    }
}