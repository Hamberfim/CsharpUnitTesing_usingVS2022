using System;
using System.Collections.Generic;
using System.Linq;
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

        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }

    }
}
