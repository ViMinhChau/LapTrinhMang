using SimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCP_IP_Chat.Controller
{
    public class ClientConfig
    {
        public static SimpleTcpClient ConfigurationClient()
        {

            string myIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            SimpleTcpClient client = new SimpleTcpClient(myIP + ":1000");
            return client;
        }

        public static string IPHost()
        {
            string myIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString() + ":1000";
            return myIP;
        }
    }
}
