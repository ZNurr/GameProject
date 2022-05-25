using GameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string? CampaignName { get; set; }
        public int CampaignPercent { get; set; }

    }
}
