using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR.DL
{
    public class StatusRepo : IStatusRepo
    {
        private readonly AppDbContext _context;
        public StatusRepo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Status> GetStatus()
        {
            return _context.Status.ToList();
        }
        public Status GetStatusById(int id)
        {
            return _context.Status.Find(id);
        }
        //public void AddStatus(Status status)
        //{
        //    _context.Status.Add(status);
        //    _context.SaveChanges();
        //}
        //public void DeleteStatus(int id)
        //{
        //    var status = _context.Status.Find(id);
        //    _context.Status.Remove(status);
        //    _context.SaveChanges();
        //}
        //public void UpdateStatus(Status status)
        //{
        //    _context.Status.Update(status);
        //    _context.SaveChanges();
        //}
    }
}
