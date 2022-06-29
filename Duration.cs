using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskcDuration
{
    internal class Duration
    {
        public int h, m, s;
        public int H
        {
            get { return h; }
            set
            {
                h = value;
            }
        }
        public int M
        {
            get { return m; }
            set
            {
                m = value;
            }
        }
        public int S
        {
            get { return s; }
            set
            {
                s = value;
            }
        }


        public Duration()
        {
            h = 0;
            m = 0;
            s = 0;
        }
        public Duration(int x)
        {
            h = x / 3600;
            m = (x % 3600) / 60;
            s = (x % 60);
        }
        public Duration(int x, int y, int z)
        {
            int temp1 = ((x * 3600) + (y * 60) + z);

            H = temp1 / 3600;
            temp1 = temp1 % 3600;
            M = temp1 / 60;
            S = temp1 % 60;
        }

        public static Duration operator +(Duration a, Duration b)
        {
            int temp1 = ((a.h * 3600) + (a.m * 60) + a.s) + ((b.h * 3600) + (b.m * 60) + b.s);

            Duration temp = new Duration();
            temp.h = temp1 / 3600;
            temp1 = temp1 % 3600;
            temp.m = temp1 / 60;
            temp.s = temp1 % 60;
            return temp;
        }
        public static Duration operator -(Duration a, Duration b)
        {
            int temp1 = ((a.h * 3600) + (a.m * 60) + a.s) - ((b.h * 3600) + (b.m * 60) + b.s);

            Duration temp = new Duration();
            temp.h = temp1 / 3600;
            temp1 = temp1 % 3600;
            temp.m = temp1 / 60;
            temp.s = temp1 % 60;
            return temp;
        }
        public static Duration operator +(Duration d1, int x)
        {
            int temp1 = (d1.h * 3600) + (d1.m * 60) + d1.s;

            temp1 += x;
            Duration temp = new Duration();
            temp.h = temp1 / 3600;
            temp1 = temp1 % 3600;
            temp.m = temp1 / 60;
            temp.s = temp1 % 60;
            return temp;
        }
        public static Duration operator -(Duration d1, int x)
        {
            int temp1 = (d1.h * 3600) + (d1.m * 60) + d1.s;

            temp1 -= x;
            Duration temp = new Duration();
            temp.h = temp1 / 3600;
            temp1 = temp1 % 3600;
            temp.m = temp1 / 60;
            temp.s = temp1 % 60;
            return temp;
        }
        public static Duration operator +(int x, Duration d1)
        {
            int temp1 = (d1.h * 3600) + (d1.m * 60) + d1.s;

            temp1 += x;
            Duration temp = new Duration();
            temp.h = temp1 / 3600;
            temp1 = temp1 % 3600;
            temp.m = temp1 / 60;
            temp.s = temp1 % 60;
            return temp;
        }
        public static Duration operator -(int x, Duration d1)
        {
            int temp1 = (d1.h * 3600) + (d1.m * 60) + d1.s;

            temp1 += x;
            Duration temp = new Duration();
            temp.h = temp1 / 3600;
            temp1 = temp1 % 3600;
            temp.m = temp1 / 60;
            temp.s = temp1 % 60;
            return temp;
        }
        public static Duration operator ++(Duration d1)
        {
            int temp1 = (d1.h * 3600) + (d1.m * 60) + d1.s;

            temp1 += 60;
            Duration temp = new Duration();
            temp.h = temp1 / 3600;
            temp1 = temp1 % 3600;
            temp.m = temp1 / 60;
            temp.s = temp1 % 60;
            return temp;
        }
        public static Duration operator --(Duration d1)
        {
            int temp1 = (d1.h * 3600) + (d1.m * 60) + d1.s;

            temp1 -= 60;
            Duration temp = new Duration();
            temp.h = temp1 / 3600;
            temp1 = temp1 % 3600;
            temp.m = temp1 / 60;
            temp.s = temp1 % 60;
            return temp;
        }
        public static bool operator >(Duration a, Duration b)
        {
            int temp1 = ((a.h * 3600) + (a.m * 60) + a.s);
            int temp2 = ((b.h * 3600) + (b.m * 60) + b.s);
            if (temp1 > temp2)
                return true;

            else
                return false;

        }
        public static bool operator <(Duration a, Duration b)
        {
            int temp1 = ((a.h * 3600) + (a.m * 60) + a.s);
            int temp2 = ((b.h * 3600) + (b.m * 60) + b.s);
            if (temp1 < temp2)
                return true;

            else
                return false;

        }
        public static bool operator >=(Duration a, Duration b)
        {
            int temp1 = ((a.h * 3600) + (a.m * 60) + a.s);
            int temp2 = ((b.h * 3600) + (b.m * 60) + b.s);
            if (temp1 > temp2)
                return true;

            else
                return false;

        }
        public static bool operator <=(Duration a, Duration b)
        {
            int temp1 = ((a.h * 3600) + (a.m * 60) + a.s);
            int temp2 = ((b.h * 3600) + (b.m * 60) + b.s);
            if (temp1 < temp2)
                return true;

            else
                return false;

        }

        public override string ToString()
        {
            return $" h: {H},m: {M},s: {S}";
        }
        public static bool operator ==(Duration obj1, Duration obj2)
        {
            if (ReferenceEquals(obj1, obj2))
            {
                return true;
            }
            if (ReferenceEquals(obj1, null))
            {
                return false;
            }
            if (ReferenceEquals(obj2, null))
            {
                return false;
            }
            return obj1.Equals(obj2);

        }
        public static bool operator !=(Duration obj1, Duration obj2)
        {
            if (ReferenceEquals(obj1, obj2))
            {
                return false;
            }
            if (ReferenceEquals(obj1, null))
            {
                return true;
            }
            if (ReferenceEquals(obj2, null))
            {
                return true;
            }
            return !(obj1.Equals(obj2));

        }
        public override bool Equals(object obj)
        {
            Duration newpoint = obj as Duration;
            if (newpoint != null && newpoint.GetType() == typeof(Duration))
                return (this.H == newpoint.H) && (this.M == newpoint.M) && (this.S == newpoint.S);
            else

                return false;
        }


        public override int GetHashCode()
        {
            return (H, M, S).GetHashCode();
        }
        public int CompareTo(object obj)
        {
            Duration h = obj as Duration;

            if (H > h.H)
            {
                return 1;
            }
            else if (H < h.H)
            {
                return -1;
            }
            else
            {
                if (M > h.M)
                {
                    return 1;
                }
                else if (M < h.M)
                {
                    return -1;
                }
                else
                {
                    if (S > h.S)
                    {
                        return 1;
                    }
                    else if (S < h.S)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }
    }
}
