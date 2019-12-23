using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolDump.Models.ApiCall
{
    class ApiConfig
    {
        public static string ChallengerApiUrl = ConfigurationManager.AppSettings["ChallengerApiUrl"];
        public static string SummonerApiUrl = ConfigurationManager.AppSettings["SummonerApiUrl"];
        public static string LeagueEntryApiUrl = ConfigurationManager.AppSettings["LeagueEntryApiUrl"];
        public static string TftApiUrl = ConfigurationManager.AppSettings["TftApiUrl"];
        public static string ApiKey = System.IO.File.ReadAllText(ConfigurationManager.AppSettings["ApiKey"]);
        
    }
}
