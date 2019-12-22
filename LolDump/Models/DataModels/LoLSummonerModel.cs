using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolDump.Models.DataModels
{
    public class LoLSummonerModel
    {
        public int profileIconId { get; set; }
        public string name { get; set; }
        public string puuid { get; set; } //Encrypted PUUID. Exact length of 78 characters.
        public int summonerLevel { get; set; }
        public long revisionDate { get; set; }
        public string id { get; set; }
        public string accountId { get; set; }
    }
}