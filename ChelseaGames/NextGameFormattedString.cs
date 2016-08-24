using System;
using NextGame;

namespace NextGame
{
    public class NextGameFormattedString
    {
        private IFootballData _footballData;

        public NextGameFormattedString(IFootballData footballData)
        {
            _footballData = footballData;
        }

        public string GetNextGameInfo()
        {
            var nextGame = _footballData.GetNextChelseaGameAfter(DateTimeOffset.UtcNow);
            
            return String.Format("Chelsea's next game is on {0:dddd, dd MMMM} at {0:hh:mm tt}, against {1}. It's at {2}.",
                               nextGame.Date.ToLocalTime(),
                               nextGame.Opponent,
                               nextGame.Venue);
        }
    }
}