using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Task3
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

            public Duration(int h, int m, int s)
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
                if (_hours > 0)
                {
                    result.Append($"Hours: {_hours}, Minutes: {_minutes}, Seconds: {_seconds}");
                }
                else
                {
                    if (_minutes > 0)
                    {
                        result.Append($"Minutes: {_minutes}, Seconds: {_seconds}");
                    }
                    else
                    {
                        result.Append($"Seconds: {_seconds}");
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

            static public bool operator == (Duration a, Duration b)
            {
                return a.Equals(b);
            }

            static public bool operator !=(Duration a, Duration b)
            {
                return !a.Equals(b);
            }

            static public Duration operator +(Duration a, Duration b)
            { 
                int seconds = (a.Second + b.Second)%60;
                int minutes = (a.Minute + b.Minute) % 60 + (a.Second+b.Second)/60;
                int hours = a.Hour + b.Hour + (a.Minute + b.Minute) / 60;
                return new Duration(s:seconds, m:minutes, h:hours);
            }
            static public Duration operator +(Duration a, int b)
            {
                Duration c = new Duration(b);
                return a + c;
            }
            static public Duration operator +(int b, Duration a)
            {
                Duration c = new Duration(b);
                return a + c;
            }

            static public Duration operator ++(Duration d)
            {
                d.Minute++;
                return d;
            }

            static public Duration operator --(Duration d)
            {
                d.Minute--;
                return d;
            }
            static public Duration operator -(Duration d)
            {
                d.Minute = -d.Minute;
                d.Second = -d.Second;
                d.Hour = -d.Hour;
                return d;
            }

            static public bool operator >(Duration a, Duration b)
            {
                int secondsA = a.Hour * 60 + a.Minute * 60 + a.Second;
                int secondsB = b.Hour*60 + b.Minute*60 + b.Second;

                return (secondsA > secondsB);
            }
            static public bool operator <(Duration a, Duration b)
            {
                if(a != b)
                {
                    return !(a > b);
                }
                else
                {
                    return false;
                }
            }

            static public bool operator <=(Duration a, Duration b)
            {
                if (a == b || a< b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            static public bool operator >=(Duration a, Duration b)
            {
                if (a == b || a> b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator true(Duration d)
            {
                return d.Hour > 0 || d.Minute > 0 || d.Second > 0;
            }

            public static bool operator false(Duration d)
            {
                return d.Hour == 0 && d.Minute == 0 && d.Second == 0;
            }

            public static explicit operator DateTime(Duration d) 
            {
                if (d == null)
                    throw new Exception();
                return DateTime.Today.AddHours(d.Hour).AddMinutes(d.Minute).AddSeconds(d.Second);
            }
        }
        static void Main(string[] args)
        {
            Duration[] durations = new Duration[4];
            durations =
            [
                new Duration (1,10,15),
                new Duration (3600),
                new Duration (7800),
                new Duration (666)
            ];

            Duration D1 = new Duration(0);
            Duration D2 = new Duration(123);
            //Console.WriteLine(D1>=D2);
            if (D1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            //Duration d2 = new Duration(7800);
            //Console.WriteLine(d2);
            //Console.WriteLine(7800 + d1);
            //if (d1 == d2)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            //foreach (Duration d in durations)
            //{
            //    Console.WriteLine(d);
            //}
            DateTime Obj = (DateTime)D1;
        }
    }
}
