using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR.DL
{
    public interface IForeignTravelRequestRepo
    {
        IEnumerable<ForeignTravelRequest> GetForeignTravelRequest();
        ForeignTravelRequest GetForeignTravelRequestById(int id);
        void AddForeignTravelRequest(ForeignTravelRequest foreignTravelRequest);
        void UpdateForeignTravelRequest(ForeignTravelRequest foreignTravelRequest);
        void DeleteForeignTravelRequest(int id);
    }
}
