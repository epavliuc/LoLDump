using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolDump.Models.DataModels
{
    public class LoLLeagueEntryModel
    {
        public string queueType { get; set; }
        public string summonerName { get; set; }
        public bool hotStreak { get; set; }
        public MiniSeries1 miniSeries { get; set; }
        public int wins { get; set; }
        public bool veteran { get; set; }
        public int losses { get; set; }
        public string rank { get; set; }
        public string leagueId { get; set; }
        public bool inactive { get; set; }
        public bool freshBlood { get; set; }
        public string tier { get; set; }
        public string summonerId { get; set; }
        public int leaguePoints { get; set; }
    }

    public class MiniSeries1
    {
        public string progress { get; set; }
        public int losses { get; set; }
        public int target { get; set; }
        public int wins { get; set; }
    }
}