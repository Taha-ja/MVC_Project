using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models.ViewModels
{
    public class EmployeCreateView
    {
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Age field is required.")]
        [Range(0, 65, ErrorMessage = "Age must be under 65")]
        public int? Age { get; set; }
        [Required]
        public string Email { get; set; }
        public IFormFile? Image { get; set; }
        [Required]
        public Departement? Departement { get; set; }
    }
}
