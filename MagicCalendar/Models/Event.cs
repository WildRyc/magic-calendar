using System.ComponentModel.DataAnnotations;

namespace MagicCalendar.Models
{
    public class Event
    {
        public int ID { get; set; }
        
        [Required]
        public MagicCalendar.Models.Organizer Organizer { get; set; }

        [Required]
        public MagicCalendar.Models.Format Format { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        public decimal? Price { get; set;}

    }
}