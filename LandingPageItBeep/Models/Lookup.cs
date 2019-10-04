using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LandingPageItBeep.Models
{
    public class Lookup
    {
        [Key]
        public int LookupID { get; set; }
        public string LookupName { get; set; }
        public string LookupNameEn { get; set; }
        public DateTime? CreatedDate;
        public int CraetedBy { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
