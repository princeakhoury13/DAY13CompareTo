using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Maximum
    {

        public static int MaximumNumber(int a, int b, int c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 || a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 || a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                return a;
            }

            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }

            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 || c.CompareTo(a) >= 0 && c.CompareTo(b) > 0 || c.CompareTo(a) > 0 && c.CompareTo(b) >= 0)
            {
                return c;

            }
            return a;
        }

        public static double MaximumFloatNumber(double a, double b, double c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 || a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 || a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                return a;
            }

            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                return b;
            }

            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 || c.CompareTo(a) >= 0 && c.CompareTo(b) > 0 || c.CompareTo(a) > 0 && c.CompareTo(b) >= 0)
            {
                return c;

            }
            return a;
        }
    }
}
