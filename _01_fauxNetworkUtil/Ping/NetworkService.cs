using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _01_fauxNetworkUtil.Ping
{
    public class NetworkService
    {
        public string SendPing()
        {
            // Assumed functions
            // SearchDNS();
            // BuildPacket();
            return "Success: Ping Sent!";
        }

        public int PingTimeOut(int a, int b)
        {
            return a + b;
        }


        // for Testing Dates, Objects, and IEnumerable 
        // date 
        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }

        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
        }

        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingOptions = new[]
            {
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },
            };
            return pingOptions;
        }
    }
}

