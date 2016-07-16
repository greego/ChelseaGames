namespace ChelseaGames
{
    using System;
    public interface IFootballData
    {
        DateTimeOffset GetNextChelseaGameDate();
        string GetNextChelseaGameOpponent();
    }
}