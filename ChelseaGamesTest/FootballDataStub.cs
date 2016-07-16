namespace ChelseaGamesTest
{
    using ChelseaGames;
    using System;

    internal class FootballDataStub : IFootballData
    {
        private DateTimeOffset _nextChelseaGame;
        private string _nextChelseaOpponent;

        public FootballDataStub(DateTimeOffset nextChelseaGame, string nextChelseaOpponent)
        {
            _nextChelseaGame = nextChelseaGame;
            _nextChelseaOpponent = nextChelseaOpponent;
        }

        public DateTimeOffset GetNextChelseaGameDate()
        {
            return _nextChelseaGame;
        }

        public string GetNextChelseaGameOpponent()
        {
            return _nextChelseaOpponent;
        }
    }
}