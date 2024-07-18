using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement
{
    internal class Duration
    {
        #region problem 3 class
        public int Hour { get; set; }

        public int Minute { get; set; }
        public int Second { get; set; }

        public Duration(int _h, int _m, int _s)
        {
            Hour = _h;
            Minute = _m;
            Second = _s;
        }

        public override string ToString()
        {
            return $"Hours: {Hour}, Minutes :{Minute}, Seconds :{Second}";
        }

        public Duration(int TotalSecond)
        {
            Hour = TotalSecond / 3600;
            Minute = (TotalSecond % 3600) / 60;
            Second = TotalSecond % 60;

            if (Second >= 60)
            {
                Minute += Second / 60;
                Second %= 60;
            }
            if (Minute >= 60)
            {
                Hour += Minute / 60;
                Minute %= 60;
            }
        }

        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration((left?.Hour ?? 0) + (right?.Hour ?? 0), (left?.Minute ?? 0) + (right?.Minute ?? 0), (left?.Second ?? 0) + (right?.Second ?? 0));


        }
        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration((d1?.Hour ?? 0), (d1?.Minute ?? 0), (d1?.Second ?? 0) + seconds);
        }
        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration((left?.Hour ?? 0) - (right?.Hour ?? 0), (left?.Minute ?? 0) - (right?.Minute ?? 0), (left?.Second ?? 0) - (right?.Second ?? 0));


        }

        public static Duration operator +(int seconds, Duration d1)
        {
            return new Duration((d1?.Hour ?? 0), (d1?.Minute ?? 0), (d1?.Second ?? 0) + seconds);
        }

        public static Duration operator ++(Duration D)
        {
            return new Duration((D?.Hour ?? 0), (D?.Minute ?? 0) + 1, (D?.Second ?? 0));
        }
        public static Duration operator --(Duration D)
        {
            return new Duration((D?.Hour ?? 0), (D?.Minute ?? 0) - 1, (D?.Second ?? 0));
        }

        public static bool operator >(Duration left, Duration right)
        {
            if (left.Hour > right.Hour)
            {
                return true;
            }
            else if (left.Minute > right.Minute)
            {
                return true;
            }
            else if (left.Second > right.Second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Duration left, Duration right)
        {
            if (left.Hour < right.Hour)
            {
                return true;
            }
            else if (left.Minute < right.Minute)
            {
                return true;
            }
            else if (left.Second < right.Second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Duration left, Duration right)
        {
            if (left.Hour <= right.Hour)
            {
                return true;
            }
            else if (left.Minute <= right.Minute)
            {
                return true;
            }
            else if (left.Second <= right.Second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(Duration left, Duration right)
        {
            if (left.Hour >= right.Hour)
            {
                return true;
            }
            else if (left.Minute >= right.Minute)
            {
                return true;
            }
            else if (left.Second >= right.Second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static explicit operator bool(Duration d)
        {
            return (d?.Hour ?? 0) != 0 || (d?.Minute ?? 0) != 0 || (d?.Second ?? 0) != 0;
        }


        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddHours(d?.Hour ?? 0).AddMinutes(d?.Minute ?? 0).AddSeconds(d?.Second ?? 0);
        }


    } 
    #endregion
}
