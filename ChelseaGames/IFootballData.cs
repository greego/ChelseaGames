namespace NextGame
{
    using System;
    public interface IFootballData
    {
        DateTimeOffset GetNextChelseaGameDate();
        string GetNextChelseaGameOpponent();
        bool GetWhetherNextChelseaGameIsAtHome();
    }
}