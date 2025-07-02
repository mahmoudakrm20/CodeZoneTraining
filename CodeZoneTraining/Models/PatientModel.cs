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
        public DateTime DateOfBirth { get; set; }
        public int AgeYears { get; set; }
        public int AgeMonths { get; set; }
        public int AgeDays { get; set; }
    }
}
