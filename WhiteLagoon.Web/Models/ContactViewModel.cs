using System.ComponentModel.DataAnnotations;

namespace WhiteLagoon.Web.Models
{
    public class ContactViewModel
    {
        [Required]
        [Display(Name = "Your Name")]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Your Email")]
        public string? Email { get; set; }

        [Required]
        [Display(Name = "Your Message")]
        [StringLength(1000, MinimumLength = 10)]
        public string? Message { get; set; }


        [StringLength(100)]
        [Display(Name = "Your Subject")]
        public string Subject { get; set; }
    }
}
