using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Web;
using System.Net;

namespace RiotApiTest
{
    class SummonerDeser
    {
        Root root = new();
        public void response_data(string api, string sum_name)
        {
            string response = new WebClient().DownloadString("https://eun1.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + sum_name + "?api_key=" + api);

            Root DeseralizedData = JsonConvert.DeserializeObject<Root>(response);
            root = DeseralizedData;
        }

        public string name_from_api(){return root.name;}

        public int level_from_api(){return root.summonerLevel;}

        public string id_from_api() { return root.id; }


        public class Root
        {
            public string id { get; set; }
            public string name { get; set; }
            public int summonerLevel { get; set; }

        }
    }

}
