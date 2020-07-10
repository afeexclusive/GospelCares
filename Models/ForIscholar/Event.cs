using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models.ForIscholar
{
    public class Event
    {
        public Guid EventId { get; set; }
        public string EvenName { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime TimeToStart { get; set; }
        public string EventDay { get; set; }
        public string Duration { get; set; }
    }
}
