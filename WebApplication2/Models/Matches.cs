using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Matches
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Group { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string Time { get; set; }

        [ForeignKey("Stadiums")]
        public Stadiums SID { get; set; }
    }
}
