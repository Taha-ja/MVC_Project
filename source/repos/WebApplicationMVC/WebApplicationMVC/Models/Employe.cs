using System.ComponentModel.DataAnnotations;


namespace WebApplicationMVC.Models
{
    public class Employe
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Age field is required.")]
        [Range(0,65,ErrorMessage ="Age msut be under 65")]
        public int? Age { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Image { get; set; }
        [Required]
        public Departement? Departement { get; set;}
    }
}
