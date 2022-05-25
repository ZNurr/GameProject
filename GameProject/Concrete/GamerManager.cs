using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        IUserValidationService _userValidationService;
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu eklendi");
            }

            else { Console.WriteLine("Doğrulama başarısız..."); }
        }
        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu güncellendi");
            }

            else { Console.WriteLine("Doğrulama başarısız..."); }
        }
        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu silindi");
            }

            else { Console.WriteLine("Doğrulama başarısız..."); }
        }
    }
}
