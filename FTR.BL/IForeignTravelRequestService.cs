using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTR.DL;

namespace FTR.BL
{
    public interface IForeignTravelRequestService
    {
        IEnumerable<ForeignTravelRequest> GetForeignTravelRequests();
        ForeignTravelRequest GetForeignTravelRequestById(int id);
        void AddForeignTravelRequest(ForeignTravelRequest foreignTravelRequest);
        void UpdateForeignTravelRequest(ForeignTravelRequest foreignTravelRequest);
        void DeleteForeignTravelRequest(int id);
    }
}
