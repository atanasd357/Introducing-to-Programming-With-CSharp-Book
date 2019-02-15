using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Task 13

namespace RetrieveFromURL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter URL adress: ");
            //string urlAdress = Console.ReadLine();
            string urlAdress = "http://www.devbg.org/forum/index.php";

            int protocolEnd = urlAdress.IndexOf("://");
            int serverEnd = urlAdress.IndexOf("/", protocolEnd + 3);

            string protocol = urlAdress.Substring(0, protocolEnd);
            string server = urlAdress.Substring(protocolEnd + 3, serverEnd - protocolEnd - 3);
            string resource = urlAdress.Substring(serverEnd, urlAdress.Length - serverEnd);

            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"\n", resource);
        }
    }
}
