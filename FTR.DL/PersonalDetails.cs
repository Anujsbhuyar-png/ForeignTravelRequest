using System.ComponentModel.DataAnnotations;

namespace FTR.DL
{
    public class PersonalDetails
    {
        [Key]
        public int employeeId { get; set; }
        public string DasId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }

        public virtual ICollection<ForeignTravelRequest> ForeignTravelRequest { get; set; }


    }
}
