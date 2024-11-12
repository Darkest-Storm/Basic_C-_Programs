using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers
            List<int> numbers = new List<int> { 2, 4, 6, 8, 16, 32, 64, 128, 256, 512, 1024, 2048 };
            //  Ask the user for a number to divide each number in the list by.
            //  Write a loop that takes each integer in the list,
            //  divides it by the number the user entered, and displays the result to the screen.
            bool valid = false; 
            while (!valid)
            {
                // User try/catch to provide error msg

                try
                {
                    
                    Console.WriteLine("\nPlease enter a number to divide the list by: ");
                    float divisor = float.Parse(Console.ReadLine());
                    // check if user entered 0
                    if (divisor == 0)
                    {
                        Console.WriteLine("Please enter a number that is not 0.");
                    }

                    // Dividing each number in list by user's input
                    else
                    {
                        foreach (int num in numbers)
                        {
                            float divide = num / divisor;
                            Console.WriteLine(num + "/" + divisor + " = " + divide);
                        }
                        valid = true;
                    }    

                }
                // Catch to display error for string input
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number");
                }

            }

            // msg to inform user the program has left try/catch block
            Console.WriteLine("\nThe try catch block has been exited");
            Console.ReadLine();
        }
    }
}
