using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCampaign.Abstracts
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
