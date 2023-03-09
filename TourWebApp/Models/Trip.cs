using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourWebApp.Models
{
    public class Trip
    {

        public Guid TripId { get; set; } = new Guid();
        [DisplayName("Trip Completed")]
        public bool Completed { get; set; }
        public float Cost { get; set; }
        public DateTime DateCompleted { get; set; }
       
        public Booking Booking { get; set; }
        public Guid BookingId { get; set; }

    }
}
