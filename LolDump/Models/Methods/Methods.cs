using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolDump.Models.Methods
{
    public static class Methods
    {

        public static DateTime FromUnixTime(long unixTime)
        {
            return epoch.AddMilliseconds(unixTime);
        }
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    }
}