using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApiTest
{
    class SummonerProfile
    {

        public string SummonerName { get; set; }
        public long Level { get; set; }
        public string Tier { get; set; }
        public string Rank { get; set; }

        public SummonerProfile(string name, long level, string tier, string rank)
        {
            SummonerName = name;
            Level = level;
            Tier = tier;
            Rank = rank;
        }


        public string getString => "Idéző: " + SummonerName + "\nSzintje: " + Level + "\nSolo/duo : " + Tier + " " + Rank;
    }
}
