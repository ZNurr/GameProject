using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirstName == "NUR"
                && gamer.LastName == "AK" && gamer.TcNo == 12345)
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
