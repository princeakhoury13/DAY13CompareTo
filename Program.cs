using Generics;

namespace generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maximum using CompareTo() Mathod");
            Console.WriteLine("Enter 1st String: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter 2nd String: ");
            string b = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter 3rd String: ");
            string c = Convert.ToString(Console.ReadLine());

            
            
            string max = Maximum.MaximumString(a, b, c);

            Console.WriteLine("The maximum of the given three String is : " + max);
            
        }

    }

}