using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models.ForIscholar
{
    public class PaymentViewModel
    {
        public string SchoolName { get; set; }
        public string StudentNamw { get; set; }
        public string SchoolSession { get; set; }
        public string Term { get; set; }
        public int AmountPaid { get; set; }
        public int Balance { get; set; }
    }
}
