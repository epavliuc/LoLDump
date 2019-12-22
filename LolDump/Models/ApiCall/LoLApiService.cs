using LolDump.Models.DataModels;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolDump.Models.ApiCall
{
    public class LoLApiService
    {
        //DTO
        public LoLApiDTO lolApiDTO = new LoLApiDTO();

        //CallManager
        public LoLApiCall lolApiCall = new LoLApiCall();

        //JObject
        public JObject lolApiJObject;

        //IRestResponse
        public IRestResponse lolApiResponse;

        public void LoLApiSumReq(string name)
        {
            lolApiDTO.DeserializeSummonerModel(lolApiCall.ApiSummonerReq(name));
            
        }
        public void LoLApiEntryReq(string sumId)
        {
            lolApiDTO.DeserializeEntryModel(lolApiCall.ApiLeagueEntryReq(sumId));
        }
        
    }
}