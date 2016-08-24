using System;
using NextGame;
using Newtonsoft.Json;

namespace FootballDataOrgDataSource
{
    public class JsonFootballData : IFootballData
    {
        private const string ChelseaTeamName = "Chelsea FC";
        private dynamic _fixtures;

        public JsonFootballData()
        {
            _fixtures = ((dynamic)JsonConvert.DeserializeObject(Properties.Resources.nextFixture_json)).fixtures;
        }

        public Fixture GetNextChelseaGameAfter(DateTimeOffset date)
        {
            foreach (var fixture in _fixtures)
            {
                if ((DateTimeOffset)fixture.date > date && (string.Equals((string)fixture.homeTeamName, ChelseaTeamName) || string.Equals((string)fixture.awayTeamName, ChelseaTeamName)))
                {
                    if (String.Equals((string)fixture.homeTeamName, ChelseaTeamName))
                    {
                        return new Fixture((DateTimeOffset)fixture.date, (string)fixture.awayTeamName, "Stamford Bridge");
                    }
                    return new Fixture((DateTimeOffset)fixture.date, (string)fixture.homeTeamName, "some crappy place");
                }
            }
            return null;
        }
    }
}