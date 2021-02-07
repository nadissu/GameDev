using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev
{
    interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
