using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolDump.Models.DataModels
{
    public class LoLApiDTO
    {
        public LoLChallengerModel lolApiChallengerModel { get; set; }
        public LoLSummonerModel lolApiSummonerModel { get; set; }
        public IList<LoLLeagueEntryModel> lolLeagueEntryModel { get; set; }
        public IList<LoLTftModel> lolTftModel { get; set; }
        public IList<LoLMasteryModel> lolMasteryModel { get; set; }
        public LoLChampionModel lolChampionModel { get; set; }

        public void DeserializeChallengerApi(String lolApiResponse)
        {
            lolApiChallengerModel = JsonConvert.DeserializeObject<LoLChallengerModel>(lolApiResponse);
        }

        public void DeserializeSummonerModel(String lolApiResponse)
        {
            lolApiSummonerModel = JsonConvert.DeserializeObject<LoLSummonerModel>(lolApiResponse);
        }

        public void DeserializeEntryModel(String lolApiResponse)
        {
            lolLeagueEntryModel = JsonConvert.DeserializeObject<IList<LoLLeagueEntryModel>>(lolApiResponse);
        }
        public void DeserializeTftModel(String lolApiResponse)
        {
            lolTftModel = JsonConvert.DeserializeObject<IList<LoLTftModel>>(lolApiResponse);
        }
        public void DeserializeMasteryModel(String lolApiResponse)
        {
            lolMasteryModel = JsonConvert.DeserializeObject<IList<LoLMasteryModel>>(lolApiResponse);
        }

        public void DeserializeChampionModel(String lolApiResponse)
        {
            lolChampionModel = JsonConvert.DeserializeObject<LoLChampionModel>(lolApiResponse);
        }
    }
}
