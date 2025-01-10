using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Stadiums
    {
        [Key]
        public int SID { get; set; }
        public string Name { get; set; }
        public double Capacity { get; set; }
        public string City { get; set; }

        public string Type { get; set; }
        public DateTime CDate { get; set; }

        public string Owenr { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public string Img { get; set; }

        public List<string> Facility { get; set; } = new List<string>();


    }
}
