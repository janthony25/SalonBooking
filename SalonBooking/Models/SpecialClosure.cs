using System.ComponentModel.DataAnnotations;

namespace SalonBooking.Models
{
    public class SpecialClosure
    {
        [Key]
        public int ClosureId { get; set; }

        [Required]  
        public DateTime Date { get; set; }

        [Required]
        public string Reason { get; set; }  
    }
}
