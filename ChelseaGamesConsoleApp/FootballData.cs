using System;
using ChelseaGames;

namespace ChelseaGamesConsoleApp
{
    internal class FootballData : IFootballData
    {
        public DateTimeOffset GetNextChelseaGameDate()
        {
            return DateTimeOffset.UtcNow;
        }

        public string GetNextChelseaGameOpponent()
        {
            return "some team";
        }
    }
}