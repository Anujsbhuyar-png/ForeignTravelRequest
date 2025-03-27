using FTR.DL;
using System.ComponentModel.DataAnnotations;

namespace FTR.UI
{
    public class DashboardViewModel
    {

        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public int FtrId { get; set; }
        
        public string VisaType { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public string ProjectName { get; set; }
        public int CurrentStep { get; set; }

    }
}
