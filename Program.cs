using Generics;

namespace generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maximum using CompareTo() Mathod");
            Console.WriteLine("Enter 1st Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            
            int max = Maximum.MaximumNumber(a, b, c);

            Console.WriteLine("The maximum of the given three numbers is : " + max);
            
        }

    }

}