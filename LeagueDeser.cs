using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;

namespace RiotApiTest
{
    class LeagueDeser
    {
        List<Ranks> ranks = new();

        public void response_data(string api, string sum_id)
        {
            string response = new WebClient().DownloadString("https://eun1.api.riotgames.com/lol/league/v4/entries/by-summoner/" +sum_id +"?api_key=" + api);
            List<Ranks> lists = JsonConvert.DeserializeObject<List<Ranks>>(response);
            
            ranks = lists;

           
        }

        public string rank_from_api(int queue) { return ranks[queue].rank; }
        public string tier_from_api(int queue) { return ranks[queue].tier; }
        public int wins_from_api(int queue) { return ranks[queue].wins; }
        public int losses_from_api(int queue) { return ranks[queue].losses; }

    }

    public class Ranks
    {
        public string tier { get; set; }
        public string rank { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
    }


}
