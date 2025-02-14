using System.ComponentModel.DataAnnotations;

namespace SalonBooking.Models
{
    public class BusinessDay
    {
        [Key]
        public int DayId { get; set; }

        [Required]
        public string DayName { get; set; }

        public bool IsOpen { get; set; }
    }
}
