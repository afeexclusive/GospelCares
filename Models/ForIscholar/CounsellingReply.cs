using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models.ForIscholar
{
    public class CounsellingReply
    {
        public Guid CounsellingReplyId { get; set; }
        public string Message { get; set; }
        public DateTime TimePosted { get; set; }
        public DateTime TimeModified { get; set; }
        public CounsellingQuestion CounsellingQuestion { get; set; }
    }
}
