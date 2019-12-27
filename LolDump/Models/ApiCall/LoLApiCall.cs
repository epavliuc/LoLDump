using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LolDump.Models.ApiCall
{
    public class LoLApiCall
    {
        public IRestClient Client { get; set; }
        public IRestResponse Response { get; set; }

        //request challenger ladder
        public string ApiChallengerReq() 
        {
            var request = new RestRequest();
            Client = new RestClient(ApiConfig.ChallengerApiUrl);
            Client.AddDefaultHeader("X-Riot-Token", ApiConfig.ApiKey);
            Response = Client.Execute(request);

            return Response.Content;
        }

        //request summoner details
        public string ApiSummonerReq(string name)
        {
            var request = new RestRequest();
            Client = new RestClient(ApiConfig.SummonerApiUrl + name);
            Client.AddDefaultHeader("X-Riot-Token", ApiConfig.ApiKey);
            Response = Client.Execute(request);

            return Response.Content;
        }

        //request league entry 
        public string ApiLeagueEntryReq(string sumId)
        {
            var request = new RestRequest();
            Client = new RestClient(ApiConfig.LeagueEntryApiUrl + sumId);
            Client.AddDefaultHeader("X-Riot-Token", ApiConfig.ApiKey);
            Response = Client.Execute(request);

            return Response.Content;
        }

        //request Tft entry
        public string ApiTftReq(string sumId)
        {
            var request = new RestRequest();
            Client = new RestClient(ApiConfig.TftApiUrl + sumId);
            Client.AddDefaultHeader("X-Riot-Token", ApiConfig.ApiKey);
            Response = Client.Execute(request);

            return Response.Content;
        }
        public string ApiMasteryReq(string sumId)
        {
            var request = new RestRequest();
            Client = new RestClient(ApiConfig.MasteryApiUrl + sumId);
            Client.AddDefaultHeader("X-Riot-Token", ApiConfig.ApiKey);
            Response = Client.Execute(request);

            return Response.Content;
        }

        public string ApiChampionReq()
        {
            var request = new RestRequest();
            Client = new RestClient("http://ddragon.leagueoflegends.com/cdn/9.24.2/data/en_US/champion.json");
            Response = Client.Execute(request);

            return Response.Content;
        }
    }
}
