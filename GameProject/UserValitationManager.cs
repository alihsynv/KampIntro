using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValitationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirtYear == 2000 && gamer.FirstName == "ALI" 
                && gamer.LastName == "HUSEYNOV" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
