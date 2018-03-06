using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace LTM_Buoi1_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap ip hoac ten mien : ");
            string host = Console.ReadLine();

            IPHostEntry entry = Dns.Resolve(host);
            Console.WriteLine("Hostname : " + entry.HostName);
            int ip = 0;
            foreach (IPAddress ipinhost in entry.AddressList)
                Console.WriteLine(" Ip : " + ipinhost);
            
        }
        }
    }
