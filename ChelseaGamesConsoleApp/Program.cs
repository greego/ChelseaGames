using FootballDataOrgDataSource;
using NextGame;
using System;

namespace NextGameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new NextGameFormattedString(new JsonFootballData()).GetNextGameInfo());
        }
    }
}
