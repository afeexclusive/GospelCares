using GospelCares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.ViewModels
{
    public class AdminViewModel
    {
        public IList<Request> ConfirmedRequest { get; set; }
        public IList<Request> UnConfirmedRequest { get; set; }
        public IList<Request> TreatedRequest { get; set; }

        public IList<Supply> PendingSupply { get; set; }
        public IList<Supply> TreatedSupply { get; set; }
    }
}
