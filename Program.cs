using Generics;

namespace generics
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Integer Values");
            Maximum.Compare<int>(12, 11, 1);
            Console.WriteLine("Double Values");
            Maximum.Compare<double>(1.1, 3.5, 3.4);
            Console.WriteLine("String Values");
            Maximum.Compare<string>("ab", "abc", "abcd");

        }

    }

}