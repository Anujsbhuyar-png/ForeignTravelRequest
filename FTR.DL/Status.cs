using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR.DL
{
    public class Status
    {
        [Key]
        public int statusId { get; set; }
        [Required]
        public string statusName { get; set; }
        public string statusDescription { get; set; }

    }
}
