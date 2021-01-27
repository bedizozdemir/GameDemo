using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;

namespace GameDemo.Concrete
{
    internal class GameCampaign : BaseCampaignManager
    {
        public override void Add(Player player, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been added for " + player.FirstName+" "+ player.LastName+".");
        }
        public override void Delete(Player player, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been deleted for " + player.FirstName + " " + player.LastName + ".");
        }

        public override void Update(Player player, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been updated for " + player.FirstName + " " + player.LastName + ".");
        }
    }
}
