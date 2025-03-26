using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FTR.DL
{
    public class ForeignTravelRequestRepo : IForeignTravelRequestRepo
    {
        private readonly AppDbContext _context;
        public ForeignTravelRequestRepo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ForeignTravelRequest> GetForeignTravelRequest()
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
