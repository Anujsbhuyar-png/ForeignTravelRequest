using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR.BL.ViewModels
{
    public class DashboardViewModel
    {
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public int FtrId { get; set; }
        public string VisaType { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int CurrentStep { get; set; }
    }
}
