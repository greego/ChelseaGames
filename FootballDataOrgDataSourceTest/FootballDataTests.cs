namespace FootballDataOrgDataSourceTest
{
    using FootballDataOrgDataSource;
    using NUnit.Framework;
    using System;
    using Shouldly;

    [TestFixture]
    public class FootballDataTests
    {
        [Test]
        public void GivenADate_WhenNextChelseaGameDateIsRequested_ThenReturnFirstFixtureAfterThatDate()
        {
            new JsonFootballData().GetNextChelseaGameAfter(new DateTimeOffset(2016, 08, 24, 0, 0, 0, TimeSpan.FromHours(10))).Date.ShouldBe(DateTimeOffset.Parse("2016-08-27T14:00:00Z"));
        }

        [Test]
        public void GivenADate_WhenNextChelseaGameOpponentIsRequested_ThenReturnOpponentForTheNextFixture()
        {
            new JsonFootballData().GetNextChelseaGameAfter(new DateTimeOffset(2016, 08, 24, 0, 0, 0, TimeSpan.FromHours(10))).Opponent.ShouldBe("Burnley FC");
        }

        [Test]
        public void GivenADate_WhenNextChelseaGameVenueIsRequested_ThenReturnStamfordBridge()
        {
            new JsonFootballData().GetNextChelseaGameAfter(new DateTimeOffset(2016, 08, 24, 0, 0, 0, TimeSpan.FromHours(10))).Venue.ShouldBe("Stamford Bridge");
        }
    }
}
