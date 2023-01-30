﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourWebApp.Models
{
    public class Bookings
    {
        [Key]
        [DisplayName("Booking ID")]
        public Guid BookingId { get; set; }

        [ForeignKey("Destination")]
        [Required]
        public Guid DestinationID { get; set; }
        [Required]
        public string Origin { get; set; }
        [DisplayName("StartDate")]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
        [DisplayName("Day Booked")]
        public DateTime DayBooked { get; set; } = DateTime.Now;
        public bool Indiviual { get; set; }
        [DisplayName("Group Size")]
        public int Groupsize { get; set; }
        [DisplayName("Hotel Booked")]
        public string HotelBooked { get; set; }
        [DisplayName("TotalBill")]
        public float TotalBill { get; set; }
        public bool Cancelled { get; set; }

    }
}
