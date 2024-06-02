using System.ComponentModel.DataAnnotations;

namespace MagicCalendar.Models
{
    public class Organizer
    {
        public int OrganizerID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}