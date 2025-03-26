using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR.DL
{
    public class PersonalDetailsRepo : IPersonalDetailsRepo
    {
        private readonly AppDbContext _context;
        public PersonalDetailsRepo(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<PersonalDetails> GetPersonalDetails()
        {
            return _context.PersonalDetails.ToList();
        }
        public PersonalDetails GetPersonalDetailsById(int id)
        {
            return _context.PersonalDetails.Find(id);
        }
        public void AddPersonalDetails(PersonalDetails personalDetails)
        {
            if (personalDetails == null)
            {
                throw new ArgumentNullException(nameof(personalDetails));
            }
            _context.PersonalDetails.Add(personalDetails);
            _context.SaveChanges();
        }
        public void UpdatePersonalDetails(PersonalDetails personalDetails)
        {
            _context.PersonalDetails.Update(personalDetails);
            _context.SaveChanges();
        }
        public void DeletePersonalDetails(int id)
        {
            var personalDetails = _context.PersonalDetails.Find(id);
            if (personalDetails != null)
            {
                _context.PersonalDetails.Remove(personalDetails);
                _context.SaveChanges();
            }
          
        }
    }
}
