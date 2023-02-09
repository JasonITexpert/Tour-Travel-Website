using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourWebApp.Models
{
    public class Trips
    {
        [Key]
        public Guid ApplicationUserId { get; set; }
        [DisplayName("Trip Completed")]
        [Required]
        public  int? Completed { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [DisplayName("Bookings")]
        public List<Booking> Bookings { get; set; }

    }
}
