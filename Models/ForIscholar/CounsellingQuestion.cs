using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models.ForIscholar
{
    public class CounsellingQuestion
    {
        public Guid CounsellingQuestionId { get; set; }
        public Guid StudentId { get; set; }
        public string Question { get; set; }
        public DateTime TimePosted { get; set; }
        public DateTime TimeModified { get; set; }
        public List<CounsellingReply> CounsellingReplies { get; set; }
    }
}
