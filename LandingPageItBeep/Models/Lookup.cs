﻿using System;
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
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public int CraetedBy { get; set; } = 1;
        [Required]
        public bool? IsDeleted { get; set; }
        public ICollection<LookupCategory> LookupCategories { get; set; }
    }
}
