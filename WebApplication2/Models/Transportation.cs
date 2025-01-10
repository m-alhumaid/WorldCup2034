using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Transportation
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public int Capacity { get; set; }

        [ForeignKey("CategorieTransportaion")]
        public TransportationCategories vehicle { get; set; }

        public string Img { get; set; }
        public string Version { get; set; }

        public string color { get; set; }
    }
}
