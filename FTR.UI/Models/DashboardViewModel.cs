using FTR.DL;
using System.ComponentModel.DataAnnotations;

namespace FTR.UI
{
    public class DashboardViewModel
    {

        public string EmployeeName { get; set; }
        public string Department { get; set; }

        [Key]
        public int FtrId { get; set; }
        [Required]
        public string VisaType { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]

        public string ProjectName { get; set; }
        public int CurrentStep { get; set; }

    }
}
