using GospelCares.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models
{
    public class SQLRepository : ICare
    {
        private readonly ApplicationDbContext _context;

        public SQLRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Request AddRequest(Request request)
        {
            _context.Add(request);
            _context.SaveChanges();
            return request;
        }

        public Request UpdateRequest(Request request)
        {
            var Changerequest = _context.Requests.Attach(request);
            Changerequest.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return request;
        }

        public Request GetRequest(int id)
        {
            return _context.Requests.Find(id);
        }

        public IEnumerable<Request> GetAllRequests()
        {
            return _context.Requests;
        }

        public IEnumerable<Request> GetConfirmedRequest(NeedStatus needStatus)
        {
            return _context.Requests.Where(r => r.Status == needStatus);
        }
        public IEnumerable<Request> GetTreatedRequest(NeedStatus needStatus)
        {
            return _context.Requests.Where(r => r.Status == needStatus);
        }

        public IEnumerable<Request> GetUnconfirmedRequests(NeedStatus needStatus)
        {
            return _context.Requests.Where(r => r.Status == needStatus);
        }

        public Supply AddSupply(Supply supply)
        {
            _context.Add(supply);
            _context.SaveChanges();
            return supply;
        }

        public Supply UpdateSupply(Supply supply)
        {
            var Changesupply = _context.Supplies.Attach(supply);
            Changesupply.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return supply;
        }

        public IEnumerable<Supply> GetAllSupplies()
        {
            return _context.Supplies;
        }

        public IEnumerable<Supply> GetPendingSupplies(SupplyStatus SStatus)
        {
            return _context.Supplies.Where(r => r.SStatus == SStatus);
        }

        public IEnumerable<Supply> GetTreatedSupplies(SupplyStatus SStatus)
        {
            return _context.Supplies.Where(r => r.SStatus == SStatus);
        }

        public Supply GetSupply(int id)
        {
            return _context.Supplies.Find(id);
        }

        
    }
}
