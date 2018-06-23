using ConsoleApp1.Model;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var worldcup = new WorldCup() { HostCountry = "Russia",ChanpionCountry = "Burunland", EventYear = 2018 };

            Console.WriteLine("Hello World!");
        }
    }
}
