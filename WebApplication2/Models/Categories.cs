using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Categories
    {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }
            public string Url { get; set; }
        }
    }

