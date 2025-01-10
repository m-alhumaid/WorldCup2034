using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public int ReviewCount { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Facility { get; set; } = new List<string>();
        public double DistanceFromCentre { get; set; }
        public bool IsNew { get; set; }

    }
}
