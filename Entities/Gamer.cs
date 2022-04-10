using System;
using System.Collections.Generic;
using System.Text;

namespace GameCampaign.Entities
{
    class Gamer
    {
        public int Id { get; set; }
        public string NationallyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
