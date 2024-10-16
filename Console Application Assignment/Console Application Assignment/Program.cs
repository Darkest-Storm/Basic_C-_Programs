using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();
           
            // Convert user input to double
            double number = Convert.ToDouble(userInput);
            
            // Multiply by 50 and print result
            double result1 = number * 50;
            Console.WriteLine(number + " multiplied by 50 is: " + result1);
           
            // Add 25 and print result
            double result2 = number + 25;
            Console.WriteLine(number + " plus 25 is: " + result2);
            
            // Divide by 12.5 and print result
            double result3 = number / 12.5;
            Console.WriteLine(number + " divided by 12.5 is: " + result3);
            
            // Check if greater than 50 and print boolean result
            bool result4 = number > 50;
            Console.WriteLine("Is " + number + " greater than 50? " + result4);
            
            // Calculate remainder when divided by 7 and print result
            double result5 = number % 7;
            Console.WriteLine("The remainder when " + number + " is divided by 7 is: " + result5);

            Console.ReadLine();

        }
    }
}
