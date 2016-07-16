namespace ChelseaGamesTest
{
    using System;
    using NUnit.Framework;
    using ChelseaGames;

    [TestFixture]
    public class NextGameTests
    {
        [Test]
        public void GivenDataSourceKnowsUpcomingChelseaGames_WhenAppStarts_ThenTellMeWhenTheNextOneIs()
        {
            var expectedNextChelseaGameDate = new DateTimeOffset(2016, 8, 1, 11, 12, 23, TimeSpan.FromHours(0));
            Assert.AreEqual(expectedNextChelseaGameDate, GetDataSourceStub(expectedNextChelseaGameDate, string.Empty).GetNextChelseaGameDate());
        }

        [Test]
        public void GivenDataSourceKnowsUpcomingChelseaGames_WhenAppStarts_ThenTellMeWhoTheNextOneIsAgainst()
        {
            var expectedNextChelseaGameOpponent = "some team";
            Assert.AreEqual(expectedNextChelseaGameOpponent, GetDataSourceStub(DateTimeOffset.UtcNow, expectedNextChelseaGameOpponent).GetNextChelseaGameOpponent());
        }

        private IFootballData GetDataSourceStub(DateTimeOffset nextChelseaGameDate, string nextChelseaOpponent)
        {
            return new FootballDataStub(nextChelseaGameDate, nextChelseaOpponent);
        }
    }
}
