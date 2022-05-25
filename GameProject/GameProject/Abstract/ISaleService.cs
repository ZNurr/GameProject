using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;


namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Add(Sales sale);
        void Update(Sales sale);
        void Delete(Sales sale);
        void Buy(Game game,Gamer gamer);
        public void Buy(Game game);
        public void BuyDiscount(Game game, Gamer gamer);

    }
}
