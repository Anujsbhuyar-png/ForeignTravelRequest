using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTR.DL;

namespace FTR.BL
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepo _statusRepo;

        public StatusService(IStatusRepo statusRepo)
        {
            _statusRepo = statusRepo;
        }

        public IEnumerable<Status> GetStatus()
        {
            return _statusRepo.GetStatus();
        }
        public Status GetStatusById(int id)
        {
            return _statusRepo.GetStatusById(id);
        }
        //public void AddStatus(Status status)
        //{
        //    _statusRepo.AddStatus(status);
        //}
        //public void UpdateStatus(Status status)
        //{
        //    _statusRepo.UpdateStatus(status);
        //}
        //public void DeleteStatus(int id)
        //{
        //    _statusRepo.DeleteStatus(id);
        //}

    }
}
