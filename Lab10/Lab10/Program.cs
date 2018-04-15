using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            var fruits = new[] { "apple", "mango", "orange", "apricot", "cherry", "grape", "blueberry" };

            Console.Write("Fruits: \n");

            foreach (var element in fruits)
            {
                Console.WriteLine($" {element}");
            }

            Console.Write("\n \n");

            //Question2
            var fruitBasket =
                 from fruit in fruits
                 let uppercaseString = fruit.ToUpper()
                 where uppercaseString.StartsWith("A")
                 orderby uppercaseString
                 select uppercaseString;

            Console.Write("These fruits in the basket with A:");

            foreach (var item in fruitBasket)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            Console.Write("\n \n");

            //Question 3 
            var months = new List<string>();     
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");
                       
            Console.WriteLine("Months:" + $"Count = {months.Count}; Capacity = {months.Capacity}");

            foreach (var item in months)
            {
                Console.WriteLine($" {item}");           
            }

            months.Insert(0, "January");             
            months.Insert(1, "February");
            months.Insert(2, "March");
            months.Insert(3, "April");
            months.Insert(4, "May");
            months.Insert(5, "June");

            Console.Write("\n ");
            Console.WriteLine("12 Months: ");
            
            foreach (var item in months)
            {
                Console.WriteLine($" {item}");
            }

            //Question4
            //Will not display anything, because only the 1st 6 months have an 'ary' ending
            months.Remove("January");            
            months.Remove("February");
            months.Remove("March");
            months.Remove("April");
            months.Remove("May");
            months.Remove("June");

            Console.Write("\n ");
            Console.WriteLine("If we remove 6 months: " + $"Count = {months.Count}; Capacity = {months.Capacity}");
                       
            var ending = months.Where(n => n.Contains("ary"));

            foreach (var item in ending)
            {
                Console.WriteLine($" {item}");
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
