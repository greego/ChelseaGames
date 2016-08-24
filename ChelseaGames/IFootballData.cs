namespace NextGame
{
    using System;
    public interface IFootballData
    {
        Fixture GetNextChelseaGameAfter(DateTimeOffset date);
    }
}