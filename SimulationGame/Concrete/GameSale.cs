using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entity;
using GameDemo.Abstract;

namespace GameDemo.Concrete
{
    class GameSale : BaseSaleManager
    {
        public override void Add(Player player, Sale sale, Campaign campaign)
        {
            Console.WriteLine(sale.SaleName+" has been added for you "+player.FirstName+" "+player.LastName+" if you want you may add the campaign "+campaign.CampaignName);
        }

        public override void Delete(Player player, Sale sale, Campaign campaign)
        {
            Console.WriteLine(sale.SaleName + " has been deleted for you " + player.FirstName + " " + player.LastName + " you may not add the campaign " + campaign.CampaignName);
        }

        public override void Update(Player player, Sale sale, Campaign campaign)
        {
            Console.WriteLine(sale.SaleName + " has been updated for you " + player.FirstName + " " + player.LastName + " if you want you may add the updated campaign " + campaign.CampaignName);
        }
    }
}
