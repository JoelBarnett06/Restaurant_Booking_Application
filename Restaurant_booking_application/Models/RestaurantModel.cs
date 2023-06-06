using System.ComponentModel.DataAnnotations;

namespace Restaurant_booking_application.Models
{
    public class RestaurantModel
    {
        [Required]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string PhoneNumber { get; set; }
        public int TwoSeats { get; set; }
        public int FourSeats { get; set; }
        public int SixSeats { get; set; } 
        public int EightSeats { get; set; }
    }
}
