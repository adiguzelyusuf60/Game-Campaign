using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCampaign.Abstracts
{
    interface IGameSalesService
    {
        void Sales(Gamer gamer, Game game);
        void SalesWithCampaign(Gamer gamer, Game game, Campaign campaign);
    }
}
