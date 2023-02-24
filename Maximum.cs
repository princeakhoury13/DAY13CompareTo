using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Maximum
    {

       

        public static void  Compare<T>(T a, T b, T c) where T : IComparable
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 || a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 || a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                Console.WriteLine("Maximum element is "+a);
            }

            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                Console.WriteLine("Maximum element is " + b);
            }

            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 || c.CompareTo(a) >= 0 && c.CompareTo(b) > 0 || c.CompareTo(a) > 0 && c.CompareTo(b) >= 0)
            {
                Console.WriteLine("Maximum element is " + c);

            }
           
        }
    }
}
