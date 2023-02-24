using Generics;

namespace generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maximum using CompareTo() Mathod");
            Console.WriteLine("Enter 1st Number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number: ");
            double c = Convert.ToDouble(Console.ReadLine());

            
            
            double max = Maximum.MaximumFloatNumber(a, b, c);

            Console.WriteLine("The maximum of the given three numbers is : " + max);
            
        }

    }

}