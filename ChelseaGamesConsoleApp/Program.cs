using ChelseaGames;
using FootballDataOrgDataSource;
using System;

namespace ChelseaGamesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFootballData data = new JsonFootballData();
            Console.WriteLine("Chelsea's next game is at {0}, against {1}", data.GetNextChelseaGameDate().ToLocalTime(), data.GetNextChelseaGameOpponent());
        }
    }
}
