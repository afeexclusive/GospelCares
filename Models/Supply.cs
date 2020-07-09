using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models
{
    public class Supply
    {
        public int SupplyId { get; set; }

        [Required]
        public string FullName { get; set; }

        
        public NeedItems Need { get; set; }

        [Required]
        public string NeedDetails { get; set; }

        [Required] 
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }
        public SupplyStatus SStatus { get; set; }

    }

    public enum SupplyStatus
    {
        pending,
        Supplied
    }

}

