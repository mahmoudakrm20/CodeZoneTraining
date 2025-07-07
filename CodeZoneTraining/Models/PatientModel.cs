using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace CodeZoneTraining.Models
{
    public class PatientModel
    {
        [Required(ErrorMessage = "Arabic name is required")]
        public string? NameAr { get; set; }

        [Required(ErrorMessage = "English name is required")]
        public string? NameEn { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "National ID is required")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "National ID must be 14 digits")]
        public string? NationalId { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateOnly? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Profile image is required")]
        public IBrowserFile? ProfileImage { get; set; }

        [Required(ErrorMessage = "Attachment is required")]
        public IBrowserFile? Attachment { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Military status is required")]
        public string? MilitaryStatus { get; set; }
    }
    
}
