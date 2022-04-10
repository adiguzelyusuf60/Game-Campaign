using GameCampaign.Concretes;
using GameCampaign.Entities;
using System;

namespace GameCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() { Id = 1, NationallyId = "12345678910", FirstName = "Yusuf", LastName = "Adıgüzel", DateOfBirth = new DateTime(2000, 11, 8) };
            Game game = new Game() {GameId = 1, GameName = "Minecraft", GamePrice = 599.99};
            Campaign campaign = new Campaign() {CampaignId = 1, CampaignName = "Ramazan Bayramı", CampaignDiscount = 20};

            BaseGamerManager baseGamerManager = new BaseGamerManager();
            baseGamerManager.Add(gamer);
            baseGamerManager.Delete(gamer);
            baseGamerManager.Update(gamer);

            Console.WriteLine("=================================================");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            Console.WriteLine("=================================================");

            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.Sales(gamer, game);
            gameSalesManager.SalesWithCampaign(gamer, game, campaign);

        }
    }
}
