using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Hospital { 
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
    }
}