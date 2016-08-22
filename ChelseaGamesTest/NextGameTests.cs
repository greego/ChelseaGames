namespace NextGameTests
{
    using System;
    using NUnit.Framework;
    using NextGame;
    using Shouldly;

    [TestFixture]
    public class NextGameTests
    {
        [Test]
        public void ShouldFormatNextHomeGameInfo()
        {
            var target = new NextGameFormattedString(GetDataSourceStub(new DateTimeOffset(2016, 8, 2, 11, 12, 23, TimeSpan.FromHours(0)),
                                                                                                                                 "Liverpool",
                                                                                                                                 true));

            target.GetNextGameInfo().ShouldBe("Chelsea's next game is on Tuesday, 02 August at 09:12 PM, against Liverpool. It's at home.");
        }

        [Test]
        public void ShouldFormatNextAwayGameInfo()
        {
            var target = new NextGameFormattedString(GetDataSourceStub(new DateTimeOffset(2017, 10, 2, 3, 4, 5, TimeSpan.FromHours(4)),
                                                                                                                                 "Manchester United",
                                                                                                                                 false));

            target.GetNextGameInfo().ShouldBe("Chelsea's next game is on Monday, 02 October at 10:04 AM, against Manchester United. It's not at home.");
        }

        private IFootballData GetDataSourceStub(DateTimeOffset nextChelseaGameDate, string nextChelseaOpponent, bool atHome)
        {
            return new FootballDataStub(nextChelseaGameDate, nextChelseaOpponent, atHome);
        }
    }
}
