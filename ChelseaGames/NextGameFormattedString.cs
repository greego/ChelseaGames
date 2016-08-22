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
            return String.Format("Chelsea's next game is on {0:dddd, dd MMMM} at {0:hh:mm tt}, against {1}. It's {2}at home.",
                               _footballData.GetNextChelseaGameDate().ToLocalTime(),
                               _footballData.GetNextChelseaGameOpponent(),
                               _footballData.GetWhetherNextChelseaGameIsAtHome() ? String.Empty : "not ");
        }
    }
}