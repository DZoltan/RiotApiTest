using System;

namespace RiotApiTest
{
    class Program
    {
        static SummonerDeser sumdeser = new();
        static LeagueDeser leagdeser = new();

        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az idézőneved!");
            string name = Console.ReadLine();
            Console.WriteLine("Add meg a kulcsot!");
            string api = Console.ReadLine();
            send_data_to_profile(name,api);
            Console.ReadLine();
            
        }

        static void send_data_to_profile(string name, string api)
        {
            
            sumdeser.response_data(api, name);
            leagdeser.response_data(api, sumdeser.id_from_api());
            SummonerProfile profile = new(sumdeser.name_from_api(), sumdeser.level_from_api(), leagdeser.tier_from_api(0), leagdeser.rank_from_api(0));
            Console.WriteLine(profile.getString);
            Console.WriteLine("Gyözelmek: " + leagdeser.wins_from_api(0) + " Vereségek: " + leagdeser.losses_from_api(0));
            Console.WriteLine("Flex: " + leagdeser.tier_from_api(1) + " " + leagdeser.rank_from_api(1));
            Console.WriteLine("Gyözelmek: " + leagdeser.wins_from_api(1) + " Vereségek: " + leagdeser.losses_from_api(1));

        }
    }
}
