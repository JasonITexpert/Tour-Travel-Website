using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TourWebApp.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Specific Destination")]
        public string DestinationName { get; set; }

        [DisplayName("Destination Country")]
        public string DestinationCountry { get; set; }
    }
}
