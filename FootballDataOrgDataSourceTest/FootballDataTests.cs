
using FootballDataOrgDataSource;
using NUnit.Framework;
using System;

namespace FootballDataOrgDataSourceTest
{
    [TestFixture]
    public class FootballDataTests
    {
        [Test]
        public void WhenNextChelseaGameDateIsRequested_ThenReturnFirstFixturesDate()
        {
            var expectedDate = DateTimeOffset.Parse("2016-08-13T14:00:00Z");
            var data = new JsonFootballData();
            Assert.AreEqual(expectedDate, data.GetNextChelseaGameDate());
        }

        [Test]
        public void WhenNextChelseaGameOpponentIsRequested_ThenReturnFirstFixturesAwayTeamName()
        {
            var expectedOpponent = "West Ham United FC";
            var data = new JsonFootballData();
            Assert.AreEqual(expectedOpponent, data.GetNextChelseaGameOpponent());
        }
    }
}
