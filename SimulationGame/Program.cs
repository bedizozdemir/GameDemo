using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entity;
using System;

namespace SimulationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Elif";
            player1.LastName = "Özdemir";
            player1.IdentityNum = "1234567890";
            player1.BirthYear = 1995;

            Player player2 = new Player();
            player2.Id = 2;
            player2.FirstName = "Ünver";
            player2.LastName = "Öz";
            player2.IdentityNum = "0987654321";
            player2.BirthYear = 1996;


            Sale sale1 = new Sale();
            sale1.SaleId = 1;
            sale1.SaleName = "Game #1 on Sale";

            Sale sale2 = new Sale();
            sale2.SaleId = 2;
            sale2.SaleName = "Game #2 on Sale";


            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Campaign #1";

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 2;
            campaign2.CampaignName = "Campaign #2";



            BasePlayerManager playerManager = new GamePlayer();
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Delete(player1);
            playerManager.Delete(player2);
            playerManager.Update(player1);
            playerManager.Update(player2);

            BaseCampaignManager campaignManager = new GameCampaign();
            campaignManager.Add(player1, campaign1);
            campaignManager.Add(player2, campaign2);
            campaignManager.Delete(player1, campaign1);
            campaignManager.Delete(player2, campaign2);
            campaignManager.Update(player1, campaign1);
            campaignManager.Update(player2, campaign2);


            BaseSaleManager saleManager = new GameSale();
            saleManager.Add(player1, sale1,campaign1);
            saleManager.Add(player2, sale2, campaign2);
            saleManager.Delete(player1, sale1, campaign1);
            saleManager.Delete(player2, sale2, campaign2);
            saleManager.Update(player1, sale1, campaign1);
            saleManager.Update(player2, sale2, campaign2);
        }
    }
}
