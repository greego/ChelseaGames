namespace NextGameTests
{
    using NextGame;
    using System;

    internal class FootballDataStub : IFootballData
    {
        private Fixture _fixture;

        public FootballDataStub(DateTimeOffset nextChelseaGame, string nextChelseaOpponent, bool atHome)
        {
            _fixture = new Fixture(nextChelseaGame, nextChelseaOpponent, atHome ? "Stamford Bridge" : "some crappy place");
        }

        public Fixture GetNextChelseaGameAfter(DateTimeOffset date)
        {
            return _fixture;
        }
    }
}