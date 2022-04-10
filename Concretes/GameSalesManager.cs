using GameCampaign.Abstracts;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCampaign.Concretes
{
    class GameSalesManager : IGameSalesService
    {
        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu " + game.GameName + " adlı oyunu " + game.GamePrice + " TL fiyatıyla satın aldı.");
        }

        public void SalesWithCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            game.GamePrice = game.GamePrice * (campaign.CampaignDiscount / 100);

            Console.WriteLine(gamer.FirstName + " adlı oyuncu " + game.GameName + " adlı oyunu " + campaign.CampaignName + " adlı kampanyayla " + game.GamePrice + " TL fiyatıyla satın aldı.");
        }
    }
}
