using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreForms.Models
{
    public class ProductEditModel
    {
        public int Id { get; set; }

        
        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(maximumLength: 25, MinimumLength = 10, ErrorMessage = "Length must be between 10 to 25")]
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int Rating { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
