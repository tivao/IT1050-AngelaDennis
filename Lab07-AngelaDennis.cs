using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Lab07_AngelaDennis
    {
        static void Main(string[] args)
        {
            MyMath Result = new MyMath();

            Console.Write("Enter first amount: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second amount: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            Result.Multiply(operand1, operand2);
            Console.WriteLine("If we multiply that number we get " +Result.result);
           
            Result.Divide(operand1, operand2);
            Console.WriteLine("If we divide that number we get " + Result.result);

            Result.Add(operand1, operand2);
            Console.WriteLine("If we add that number we get " + Result.result);

            Result.Subtract(operand1, operand2);
            Console.WriteLine("If we subtract that number we get " + Result.result);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
         }
    }
}
