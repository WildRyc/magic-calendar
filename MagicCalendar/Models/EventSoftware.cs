using System.ComponentModel.DataAnnotations;
namespace MagicCalendar.Models
{
    public class EventSoftware
    {
        [Key]
        public int EventSoftwareID { get; set; }
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "Website")]
        public string URL { get; set; }

    }
}