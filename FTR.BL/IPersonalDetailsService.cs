using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTR.DL;

namespace FTR.BL
{
    public interface IPersonalDetailsService
    {
        IEnumerable<PersonalDetails> GetPersonalDetails();
        PersonalDetails GetPersonalDetailsById(int id);
        void AddPersonalDetails(PersonalDetails personalDetails);
        void UpdatePersonalDetails(PersonalDetails personalDetails);
        void DeletePersonalDetails(int id);
    }
}
