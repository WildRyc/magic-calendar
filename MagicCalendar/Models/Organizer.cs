using System.ComponentModel.DataAnnotations;

namespace MagicCalendar.Models
{
    public class Organizer
    {
        [Key]
        public int OrganizerID { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "Website")]
        public string URL { get; set; }
    }
}