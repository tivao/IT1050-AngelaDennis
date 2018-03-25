using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            Console.WriteLine(names[1]);
            Console.WriteLine(names[4]);

            Console.Write("\n \n");

            //Question 2
            {
                string[] months = {"January", "February", "March", "April", "May", "June", "July", "August",
                                                "September", "October", "November", "December"};

                for (int n1 = 0; n1 < 12; n1++)
                { Console.WriteLine(months[n1]); };               
            }

            Console.Write("\n \n");

            //Question 3
            {
                string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };

                foreach (string season in seasons)
                {
                    Console.WriteLine(season);
                }
            }
            //Question 4
            {
                {
                    /*Random someNumber = new Random();
                    int[] randomNumber = new int[1000];

                    for (int n2 = 0; n2 < 1000; n2++)
                    {
                        randomNumber[n2] = someNumber.Next(0, 1000);
                    }

                    foreach (int a in randomNumber)
                    {
                        Console.WriteLine(a);
                    }*/
                }
            }

            Console.Write("\n \n");

            //Question 5
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
                Console.Write("\nPress any key to exit...");
                Console.ReadKey(true);
            }
        }
    }
}
