﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolDump.Models.DataModels
{
    public class LoLChampionModel
    {
        public string type { get; set; }
        public string format { get; set; }
        public string version { get; set; }
        public Data data { get; set; }

    }

    public class Data
    {
        public IList<Champion> champion { get; set; }
    }

    public class Champion
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurp { get; set; }

        public Info info { get; set; }
        public Image image { get; set; }
        public IList<string> tags { get; set; }
        public string partype { get; set; }
        public Stats stats { get; set; }
    }

    public class Info
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int magic { get; set; }
        public int difficulty { get; set; }
    }

    public class Image
    {
        public string full { get; set; }
        public string sprite { get; set; }
        public string group { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Stats
    {
        public int hp { get; set; }
        public int hpperlevel { get; set; }
        public int mp { get; set; }
        public int mpperlevel { get; set; }
        public int movespeed { get; set; }
        public int armor { get; set; }
        public int armorperlevel { get; set; }
        public int spellblock { get; set; }
        public int spellblockperlevel { get; set; }
        public int attackrange { get; set; }
        public int hpregen { get; set; }
        public int hpregenperlevel { get; set; }
        public int mpregen { get; set; }
        public int mpregenperlevel { get; set; }
        public int crit { get; set; }
        public int critperlevel { get; set; }
        public int attackdamage { get; set; }
        public int attackdamageperlevel { get; set; }
        public int attackspeedperlevel { get; set; }
        public int attackspeed { get; set; }
    }

}