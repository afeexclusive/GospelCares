using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models.ForIscholar
{
    public class TermlyDue
    {
        public Guid TermlyDueId { get; set; }
        public string SchoolSession { get; set; }
        public string Term { get; set; }
        public int AmountDue { get; set; }
        public DateTime DueDate { get; set; }
    }
}
