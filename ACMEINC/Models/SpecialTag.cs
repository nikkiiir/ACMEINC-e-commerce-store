﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ACMEINC.Models
{
    public class SpecialTag
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Special Tag")]
        public string SpecialTags { get; set; }
    }
}
