using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The sum of " + n1 + " and " + n2 + " is " + (n1 + n2));


            int X,Y,Z;
            X = 22;
            Y = 13;
            Z = 5;
            var theAnswer = ((X + Y) * (Z + 10));
            Console.WriteLine("\n\nX=22, Y=13, Z=5");
            Console.WriteLine("{ X + Y} * { Z + 10}");
            Console.WriteLine("\nThe answer is " + theAnswer);

            Console.WriteLine("\n\nHello\tWorld!");
            Console.WriteLine("Hello \nWorld!");
            Console.WriteLine("\"Hello World\"");
            Console.WriteLine("Hello\\World");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
