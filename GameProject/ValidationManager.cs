using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class ValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="orhan" && gamer.LastName=="dogan" && gamer.IdentityNumber==12345 && gamer.BirthYear==1990)
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
