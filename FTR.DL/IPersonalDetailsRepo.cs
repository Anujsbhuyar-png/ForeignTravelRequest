using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTR.DL
{
    public interface IPersonalDetailsRepo
    {
        IEnumerable<PersonalDetails> GetPersonalDetails();
        PersonalDetails GetPersonalDetailsById(int id);
        void AddPersonalDetails(PersonalDetails personalDetails);
        void UpdatePersonalDetails(PersonalDetails personalDetails);
        void DeletePersonalDetails(int id);

    }
}
