using MyHttpServer;
using System;


namespace ConsoleWebServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server.Start();
            Console.ReadLine();
        }
    }
}
