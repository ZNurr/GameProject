using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;
using GameProject.Concrete;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService,ICampaignService
    {
 
        void ISaleService.Add(Sales sale)
        {
            Console.WriteLine("Satış yapildi...");
        }

        void ISaleService.Delete(Sales sale)
        {
            Console.WriteLine("Kampanya silindi...");
        }

        void ISaleService.Update(Sales sale)
        {
            Console.WriteLine("Kampanya güncellendi...");
        }
        public void Buy(Game game)
        {
            Console.WriteLine("Oyun Satin Alindi: " + game.GameName);
        }
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " "+gamer.LastName+"  tarafindan oyun Satin Alindi: " + game.GameName);
        }

        internal void Buy(Game game, object gamer)
        {
            throw new NotImplementedException();
        }
        public void BuyDiscount(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + "' nin Size Ozel Indirimli Fiyati: " + (game.GameUnitPrice - ((game.GameUnitPrice * 50) / 100)));
        }

        public void Add(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
