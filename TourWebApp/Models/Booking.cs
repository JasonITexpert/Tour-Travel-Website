using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourWebApp.Models
{
    public class Booking
    {
        [DisplayName("Booking ID")]
        public new Guid BookingId { get; set; } = new Guid();
        public string Origin { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime DayBooked { get; set; } = DateTime.Now;
        public bool Individual { get; set; }
        public uint GroupSize { get; set; }
        public bool HotelProvided { get; set; }
        public string? HotelName { get; set; }
        public float TotalBill { get; set; }
        public bool Cancelled { get; set; }
       
        public ApplicationUser ApplicationUser { get; set; }
        public Guid UserId { get; set; }
        public Trip Trip { get; set; }


    }
}
