using GospelCares.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.ViewModels
{
    public class CreateRequest
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        public string Branch { get; set; }

        [Required]
        [Display(Name = "Pastor In Charge")]
        public string PastorName { get; set; }

        public NeedItems Need { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
