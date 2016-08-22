namespace NextGameTests
{
    using NextGame;
    using System;

    internal class FootballDataStub : IFootballData
    {
        private DateTimeOffset _nextChelseaGame;
        private string _nextChelseaOpponent;
        private bool _atHome;

        public FootballDataStub(DateTimeOffset nextChelseaGame, string nextChelseaOpponent, bool atHome)
        {
            _nextChelseaGame = nextChelseaGame;
            _nextChelseaOpponent = nextChelseaOpponent;
            _atHome = atHome;
        }

        public DateTimeOffset GetNextChelseaGameDate()
        {
            return _nextChelseaGame;
        }

        public string GetNextChelseaGameOpponent()
        {
            return _nextChelseaOpponent;
        }

        public bool GetWhetherNextChelseaGameIsAtHome()
        {
            return _atHome;
        }
    }
}