using System;
using System.Text.RegularExpressions;
namespace Studia
{
    public struct Time : IEquatable<Time>, IComparable<Time>
    {

        private byte hours;
        private byte minutes;
        private byte seconds;

        public byte Hours
        {
            get { return hours; }
            private set { hours = (byte)(value % 24); }

        }

        public byte Minutes
        {
            get { return minutes; }
            private set { minutes = (byte)(value % 60); }
        }

        public byte Seconds
        {
            get { return seconds; }
            private set { seconds = (byte)(value % 60); }
        }



        public Time(byte h, byte m, byte s) : this()
        {
            // sprawdzamy czy są poprawne wartości -- jak nie to rzucamy o tym informacją;
            if (h > 23 || m > 59 || s > 59)
            {
                throw new System.ArgumentException("Sprawdź poprawność parametrów");
            }
            this.Hours = h;
            this.Minutes = m;
            this.Seconds = s;
        }
        public Time(byte h, byte m)
        {

            if (h > 23 || m > 59)
            {
                throw new System.ArgumentException("Sprawdź poprawność parametrów");
            }
            this.hours = h;
            this.minutes = m;
            this.seconds = 0;
        }
        public Time(byte h)
        {
            if (h > 23)
            {
                throw new System.ArgumentException("Sprawdź poprawność parametrów");
            }
            this.hours = h;
            this.minutes = 0;
            this.seconds = 0;
        }
        public Time(string str)
        {

            /*
            regex for HH:MM:SS  MM:SS SS
                ^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$
            regex for HH HH:MM HH:MM:SS
               ^([0-1]?\d|2[0-3])(?::([0-5]?\d))?(?::([0-5]?\d))?$ -- wybieramy ten bo lepiej pasuje do tego co już napisalismy
            */
            Regex rgx = new Regex(@"^([0-1]?\d|2[0-3])(?::([0-5]?\d))?(?::([0-5]?\d))?$");
            if (rgx.IsMatch(str))
            {
                string[] time = str.Split(":");
                this.hours = Convert.ToByte(time[0]);
                this.minutes = Convert.ToByte(time[1]); ;
                this.seconds = Convert.ToByte(time[2]); ;
            }
            else
            {
                throw new System.ArgumentException("Sprawdź poprawność parametrów");
            }


        }

        public override string ToString()
        {
            var hh = hours.ToString().PadLeft(2, '0');
            var mm = minutes.ToString().PadLeft(2, '0');
            var ss = seconds.ToString().PadLeft(2, '0');

            // return ("{0,22:X8}", hours.ToString());
            return $"{hh}:{mm}:{ss}";
        }

        #region implementacja IEquatable<Time>
        public bool Equals(Time other)
        {
            // struct nigdy nie jest null
            if (Object.ReferenceEquals(this, other))
                return true;

            return (hours == other.hours &&
                    minutes == other.minutes &&
                    seconds == other.seconds);
        }

        // przesłonięcie metod Equals i GetHashCode 
        public override bool Equals(object obj)
        {
            if (obj is Time)
                return Equals((Time)obj);
            else
                return false;
        }
        public override int GetHashCode() => (Hours, Minutes, Seconds).GetHashCode();

        //nie używam statycznego wariantu bo nie ma nulla w struct
        // przeciążenie operatora `==` i `!=`
        public static bool operator ==(Time t1, Time t2) => Equals(t1, t2);
        public static bool operator !=(Time t1, Time t2) => !(t1 == t2);

        #endregion implementacja IEquatable<Time>
        #region implementacja IComparable<Time>
        public int CompareTo(Time other)
        {
            // struct != null
            if (this.Equals(other)) return 0;
            // redukujemy sprawdzając takie same wartosci 
            if (this.hours != other.hours)
                return this.hours.CompareTo(other.hours);
            // jak godziny są równe to sprawdzamy minuty
            if (!this.minutes.Equals(other.minutes)) // != zamiast !Equals
                return this.minutes.CompareTo(other.minutes);
            // minuty są równe to sprawdzamy sekundy
            return this.seconds.CompareTo(other.seconds);
        }

        //overloading operators
        public static bool operator <(Time t1, Time t2) => t1.CompareTo(t2) < 0;
        public static bool operator >(Time t1, Time t2) => t1.CompareTo(t2) > 0;
         public static bool operator <=(Time t1, Time t2) => t1.CompareTo(t2) <= 0;
        public static bool operator >=(Time t1, Time t2) => t1.CompareTo(t2) >= 0;

        #endregion implementacja IComparable<Time>
    }
}