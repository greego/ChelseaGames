namespace NextGame
{
    using System;

    public class Fixture
    {
        private string _venue;
        private string _opponent;
        private DateTimeOffset _date;

        public Fixture(DateTimeOffset date, string opponent, string venue)
        {
            _date = date;
            _opponent = opponent;
            _venue = venue;
        }

        public DateTimeOffset Date { get {return _date;} }

        public string Opponent { get { return _opponent; } }

        public string Venue { get { return _venue; } }

    }
}