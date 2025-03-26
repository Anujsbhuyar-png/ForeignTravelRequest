using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTR.DL;

namespace FTR.BL
{
    public interface IStatusService
    {
        IEnumerable<Status> GetStatus();
        Status GetStatusById(int id);
        //void AddStatus(Status status);
        //void UpdateStatus(Status status);
        //void DeleteStatus(int id);
    }
}
