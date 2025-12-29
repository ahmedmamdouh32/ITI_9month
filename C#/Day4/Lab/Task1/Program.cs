using System.Text;

namespace Task1
{
    internal class Program
    {
        public class Duration
        {
            int _hours, _minutes, _seconds;
            public int Hour
            {
                set
                {
                    _hours = value;
                }
                get
                {
                    return _hours;
                }
            }
            public int Minute
            {
                set
                {
                    if (value > 59) throw new Exception();
                    else _minutes = value;
                }
                get
                {
                    return _minutes;
                }
            }
            public int Second
            {
                set
                {
                    if (value > 59) throw new Exception();
                    else _seconds = value;
                }
                get
                {
                    return _seconds;
                }
            }

            public Duration()
            {
                _hours = 0;
                _minutes = 0;
                _seconds = 0;
            }

            public Duration(int h, int m , int s)
            {
                _hours = h;
                _minutes = m;
                _seconds = s;
            }

            public Duration(int d)
            {
                _hours = d / 3600;
                _minutes = (d % 3600) / 60;
                _seconds = (d % 3600) % 60;
            }

            public override string ToString()
            {
                StringBuilder result = new StringBuilder();
                if(_hours > 0)
                {
                    result.Append($"Hours: {_hours}, Minutes: {_minutes}, Seconds: {_seconds}");
                }
                else
                {
                    if(_minutes > 0)
                    {
                        result.Append($"Minutes: {_minutes}, Seconds: {_seconds}");
                    }
                    else
                    {
                        result.Append($"Seconds: { _seconds}");
                    }
                }
                return result.ToString();
            }
            public override bool Equals(object? obj)
            {
                Duration d = (Duration)obj;
                return (_hours == d.Hour && _minutes == d.Minute && _seconds == d.Second);
            }
            public override int GetHashCode()
            {   //returns total number of seconds
                return _hours * 60 * 60 + _minutes * 60 + _seconds;
            }
        }
        static void Main(string[] args){
            Duration[] durations = new Duration[4];
            durations = 
            [
                new Duration (1,10,15),
                new Duration (3600),
                new Duration (7800),
                new Duration (666)
            ];

            foreach(Duration d in durations){
                Console.WriteLine(d);
            }
        }
    }
}
