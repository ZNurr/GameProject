using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignManager
    {

        public void Add(Campaign campaign)
        {
                Console.WriteLine("Kampanya eklendi...");
        }

        public void Delete(Campaign campaign)
        {  
                Console.WriteLine("Kampanya silindi...");  
        }

        public void Update(Campaign campaign)
        {
                Console.WriteLine("Kampanya güncellendi..."); 
        }
    }
}
