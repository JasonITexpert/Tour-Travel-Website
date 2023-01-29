using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TourWebApp.Models
{
    public class Booking
    {
        [Key]
        [DisplayName("Booking ID")]
        public int Id { get; set; }
        [DisplayName("StartDate")]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
        [DisplayName("Day Booked")]
        public DateTime DayBooked { get; set; } = DateTime.Now;
        [DisplayName("Hotel Booked")]
        public string HotelBooked { get; set; }
        public bool Cancelled { get; set; }
    }
}
