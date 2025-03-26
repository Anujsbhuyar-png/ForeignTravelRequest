using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR.DL
{
    public class ForeignTravelRequest
    {
        [Key]
        public int FtrId { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [MaxLength(50)]
        public string VisaType { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        public int CurrentStep { get; set; }
        public virtual PersonalDetails Employee { get; set; }
        public virtual Status Status { get; set; }
    }
}
