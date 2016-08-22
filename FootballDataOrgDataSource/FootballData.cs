using System;
using NextGame;
using Newtonsoft.Json;

namespace FootballDataOrgDataSource
{
    public class JsonFootballData : IFootballData
    {
        private const string ChelseaTeamName = "Chelsea FC";
        private dynamic _nextChelseaFixture;

        public JsonFootballData()
        {
            _nextChelseaFixture = ((dynamic)JsonConvert.DeserializeObject(Properties.Resources.nextFixture_json))
                                        .fixtures[0];
        }

        public DateTimeOffset GetNextChelseaGameDate()
        {
            return (DateTimeOffset)_nextChelseaFixture.date;
        }

        public string GetNextChelseaGameOpponent()
        {
            return (string)_nextChelseaFixture.awayTeamName;
        }

        public bool GetWhetherNextChelseaGameIsAtHome()
        {
            return ((string)_nextChelseaFixture.homeTeamName == ChelseaTeamName);
        }
    }
}