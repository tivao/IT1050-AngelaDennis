using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            /*int i = 12;
             Boolean keepLooping = true;
             while (keepLooping)
             {
                 if ( i<= 11)

                     keepLooping = false; 
                 i++;
                 Console.WriteLine(i);         
             }*/


            //Question 2
            int num = 2;
            while (num <= 128)
            {
                {
                    if ((num % 2) == 0)
                    {
                        Console.WriteLine("[{0}]", num);
                    }
                    else if ((num % 2) != 0)
                    {
                        Console.Write("");
                    }
                    num *= 2;                    
                }                
            }
            Console.Write("\n \n");

            //Question 3
            for (int x = 49; x > 0; x--)
            {
                Console.Write("{0}{1}", x, x == 1 ? "" : ",");                
            }
            Console.Write("\n \n");

            //Question 4
            int n1 = 0;
            while (n1 <= 0)
            {
                for (n1 = 1; n1 <= 22; n1++)
                {
                    if (n1 % 2 != 0)
                    {
                        Console.Write(n1 + "   ");
                    }
                }
            }
            Console.Write("\n \n");

            //Question 5
            //Explanation: The While() loop will never execute because "i" 
            //is greater than "n" to begin with and it checks the statement first.
            //the Do While() Loop will print one star because doesn't check until after it
            //runs once.
            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition

            Console.WriteLine();
            

            n = 8;
            i = 10; // initialize

            while (i < n) // test condition
            {
                Console.Write("*");
                i++; // update!
            }
            Console.Write("\n");

            //Question 6
            bool icyRain = false;
            bool tornadoWarning = false;

            if (!icyRain && !tornadoWarning)
            {
                Console.WriteLine("Let's go outside!");
            }
            Console.Write("\n \n");

            //Question 7
            for (int row = 0; row < 5; row++)
            {

                for (int space = 0; space < row; space++)
                {
                    Console.Write(" ");
                }

                for (int n2 = 0; n2 < 5 - row;)
                {
                    Console.Write(++n2);
                }

                for (int n2 = 5 - row; n2 > 1;)
                {
                    Console.Write(--n2);
                }

                for (int space = 0; space < row; space++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
            
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
