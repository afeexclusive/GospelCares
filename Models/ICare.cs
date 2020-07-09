using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models
{
    public interface ICare
    {
        public Request AddRequest(Request request);
        public Request UpdateRequest(Request request);
        public IEnumerable<Request> GetAllRequests();
        public Request GetRequest(int id);
        public IEnumerable<Request> GetUnconfirmedRequests(NeedStatus needStatus);
        public IEnumerable<Request> GetConfirmedRequest(NeedStatus needStatus);
        public IEnumerable<Request> GetTreatedRequest(NeedStatus needStatus);

        public Supply AddSupply(Supply supply);
        public Supply UpdateSupply(Supply supply);
        public IEnumerable<Supply> GetAllSupplies();
        public Supply GetSupply(int id);
        public IEnumerable<Supply> GetPendingSupplies(SupplyStatus SStatus);
        public IEnumerable<Supply> GetTreatedSupplies(SupplyStatus SStatus);
    }
}
