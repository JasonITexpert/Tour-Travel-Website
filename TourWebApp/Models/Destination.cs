using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TourWebApp.Models
{
    public class Destination
    {
        [Key]
        [DisplayName("Destination ID")]
        public Guid DestinationId { get; set; }

        [DisplayName("Specific Destination")]
        [Required]
        public string DestinationName { get; set; }

        [DisplayName("Destination Country")]
        public string DestinationCountry { get; set; }
    }
}
