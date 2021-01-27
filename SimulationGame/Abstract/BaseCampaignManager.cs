using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    class BaseCampaignManager
    {
        public void Add(Player player, Campaign campaign);
        public void Delete(Player player, Campaign campaign);
        public void Update(Player player, Campaign campaign);
    }
}
