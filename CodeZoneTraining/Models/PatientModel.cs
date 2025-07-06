using Microsoft.AspNetCore.Components.Forms;

namespace CodeZoneTraining.Models
{
    public class PatientModel
    {
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? NationalId { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public IBrowserFile? ProfileImage { get; set; }
        public IBrowserFile? Attachment { get; set; }

    }
}
