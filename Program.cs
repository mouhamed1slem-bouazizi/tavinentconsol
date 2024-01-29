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
            Console.Title = "TAV";
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("10.82.131.250", 1000);
                if (reply != null)
                {
                    Console.WriteLine("Address : " + reply.Address + "\nStatus :  " + reply.Status);
                }
            }
            catch
            {
                Console.WriteLine("ERROR: You have Some TIMEOUT issue");
            }
            Console.ReadKey();
        }
    }
}