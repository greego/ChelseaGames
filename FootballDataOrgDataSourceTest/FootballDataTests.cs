
using FootballDataOrgDataSource;
using NUnit.Framework;
using System;
using Shouldly;

namespace FootballDataOrgDataSourceTest
{
    [TestFixture]
    public class FootballDataTests
    {
        [Test]
        public void WhenNextChelseaGameDateIsRequested_ThenReturnFirstFixturesDate()
        {
            new JsonFootballData().GetNextChelseaGameDate().ShouldBe(DateTimeOffset.Parse("2016-08-13T14:00:00Z"));
        }

        [Test]
        public void WhenNextChelseaGameOpponentIsRequested_ThenReturnFirstFixturesAwayTeamName()
        {
            new JsonFootballData().GetNextChelseaGameOpponent().ShouldBe("West Ham United FC");
        }

        [Test]
        public void IfNextChelseaGameIsAtHome_ThenReturnTrue()
        {
            new JsonFootballData().GetWhetherNextChelseaGameIsAtHome().ShouldBe(true);
        }
    }
}
