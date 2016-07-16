using System;
using ChelseaGames;
using Newtonsoft.Json;

namespace FootballDataOrgDataSource
{
    public class JsonFootballData : IFootballData
    {
        private dynamic _dateOfNextChelseaFixture;

        public JsonFootballData()
        {
            _dateOfNextChelseaFixture = ((dynamic)JsonConvert.DeserializeObject(Properties.Resources.nextFixture_json))
                                        .fixtures[0];
        }

        public DateTimeOffset GetNextChelseaGameDate()
        {
            return (DateTimeOffset)_dateOfNextChelseaFixture.date;
        }

        public string GetNextChelseaGameOpponent()
        {
            return (string)_dateOfNextChelseaFixture.awayTeamName;
        }
    }
}