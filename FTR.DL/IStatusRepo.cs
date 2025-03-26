using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR.DL
{
    public interface IStatusRepo
    {
        IEnumerable<Status> GetStatus();
        Status GetStatusById(int id);
        //void AddStatus(Status status);
        //void UpdateStatus(Status status);
        //void DeleteStatus(int id);
    }
}
