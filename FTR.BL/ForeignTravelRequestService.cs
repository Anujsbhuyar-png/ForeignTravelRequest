using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTR.DL;

namespace FTR.BL
{
    public class ForeignTravelRequestService : IForeignTravelRequestService
    {
        private readonly IForeignTravelRequestRepo _requestsRepo;

        public ForeignTravelRequestService(IForeignTravelRequestRepo requestsRepo)
        {
            _requestsRepo = requestsRepo;
        }
        

        public IEnumerable<ForeignTravelRequest> GetForeignTravelRequests()
        {
            throw new NotImplementedException();
        }
        public ForeignTravelRequest GetForeignTravelRequestById(int id)
        {
            throw new NotImplementedException();
        }
        public void AddForeignTravelRequest(ForeignTravelRequest foreignTravelRequest)
        {
            throw new NotImplementedException();
        }
        public void UpdateForeignTravelRequest(ForeignTravelRequest foreignTravelRequest)
        {
            throw new NotImplementedException();
        }
        public void DeleteForeignTravelRequest(int id)
        {
            throw new NotImplementedException();
        }
    }
}
