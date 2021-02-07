using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added"+campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Add Timed"+campaign.CampaignName);
        }
    }
}
