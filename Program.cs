using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation; //Include this



namespace PingProto
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllLines("c:\\IP\\iplists.txt").Select(x => x.Split('/'));
            Dictionary<string, string> IPS = new Dictionary<string, string>();
            foreach (var line in lines)
                IPS.Add( line[0], line[1]);
        Console.Title = "TAV";
            foreach (KeyValuePair<string, string> m in IPS)
            {
                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send(m.Value, 1000);
                    if (reply != null)
                    {
                    if (reply.Status == IPStatus.Success)
                        Console.WriteLine("Address : " + reply.Address + "\nStatus :  Online");
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Address : " + reply.Address + "\nStatus :  Offline");
                        Console.ResetColor();
                    }
                    }
            }
            Console.WriteLine("Done");


            Console.ReadKey();
        }
    }
}