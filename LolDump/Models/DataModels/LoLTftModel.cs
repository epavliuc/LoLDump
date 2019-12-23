using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolDump.Models.DataModels
{
    public class LoLTftModel
    {
        public string queueType { get; set; }
        public string summonerName { get; set; }
        public bool hotStreak { get; set; }
        public MiniSeries2 miniSeries { get; set; }
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

    public class MiniSeries2
    {
        public string progress { get; set; }
        public int losses { get; set; }
        public int target { get; set; }
        public int wins { get; set; }
    }
}