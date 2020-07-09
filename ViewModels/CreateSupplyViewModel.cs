using GospelCares.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.ViewModels
{
    public class CreateSupplyViewModel
    {
        
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        public NeedItems Need { get; set; }

        [Required]
        [Display(Name ="Specify Items or Payment Details(Amount, Bank name)")]
        public string NeedDetails { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
