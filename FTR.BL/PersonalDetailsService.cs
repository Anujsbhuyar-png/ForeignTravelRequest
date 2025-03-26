using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTR.DL;

namespace FTR.BL
{
    public class PersonalDetailsService : IPersonalDetailsService
    {
        private readonly IPersonalDetailsRepo _personalDetailsRepo;

        public PersonalDetailsService(IPersonalDetailsRepo personalDetailsRepo)
        {
            _personalDetailsRepo = personalDetailsRepo;
        }
        public IEnumerable<PersonalDetails> GetPersonalDetails()
        {
            return _personalDetailsRepo.GetPersonalDetails();
        }
        public PersonalDetails GetPersonalDetailsById(int id)
        {
            return _personalDetailsRepo.GetPersonalDetailsById(id);
        }
        public void AddPersonalDetails(PersonalDetails personalDetails)
        {
            if (personalDetails == null)
            {
                throw new ArgumentNullException(nameof(personalDetails));
            }
            _personalDetailsRepo.AddPersonalDetails(personalDetails);
        }
        public void UpdatePersonalDetails(PersonalDetails personalDetails)
        {
            _personalDetailsRepo.UpdatePersonalDetails(personalDetails);
        }
        public void DeletePersonalDetails(int id)
        {
            _personalDetailsRepo.DeletePersonalDetails(id);
        }
    }
}
