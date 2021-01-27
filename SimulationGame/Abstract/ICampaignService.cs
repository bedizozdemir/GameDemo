using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entity;

namespace GameDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Player player, Campaign campaign);
        void Update(Player player, Campaign campaign);
        void Delete(Player player, Campaign campaign);
    }
}
