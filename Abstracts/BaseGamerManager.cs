using GameCampaign.Abstracts;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCampaign.Concretes
{
    class BaseGamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu eklendi: " + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi: " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi: " + gamer.FirstName);
        }
    }
}
