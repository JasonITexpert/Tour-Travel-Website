﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TourWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Range(1, 100)]
        public string? FirstName { get; set; }
        [Range(1, 100)]
        public string? LastName { get; set; }
        [Range(1, 150, ErrorMessage ="Age should be within provided range")]
        public int Age { get; set; }
        [DisplayName("Trips Pending")]
        public int TripsPending { get; set; }
        [DisplayName("Total Trips Taken")]
        public int TotalTripsTaken { get; set; }
        public float TotalSpent { get; set; }
    }
}
