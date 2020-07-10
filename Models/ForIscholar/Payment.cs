using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models.ForIscholar
{
    public class Payment
    {
        public Guid PaymentId { get; set; }
        public Guid SchoolId { get; set; }
        public Guid StudentId { get; set; }
        public string SchoolSession { get; set; }
        public string Term { get; set; }
        public int AmountPaid { get; set; }
        public int Balance { get; set; }
    }
}
