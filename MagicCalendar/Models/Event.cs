using System.ComponentModel.DataAnnotations;
using MagicCalendar.Models;

namespace MagicCalendar.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        
        #nullable disable
        [Required]
        public Organizer Organizer { get; set; }

        #nullable disable
        [Required]
        public Format Format { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        public decimal? Price { get; set;}

    }
}