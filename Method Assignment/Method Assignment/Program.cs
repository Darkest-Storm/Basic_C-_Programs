using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Insatantiate MathOps class
            MathOps newMath = new MathOps();

            // Ask user for first int
            Console.WriteLine("Enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ask user if they want to enter a second int
            Console.WriteLine("Enter an integer or press enter");
            string num2 = Console.ReadLine();

            // check if user has no input run the method with only 1 parameter
            if (string.IsNullOrEmpty(num2))
            {
                int answer = newMath.MathOperation(num1);
                Console.WriteLine(num1 + " x Default 1 = " + answer);
            }
            
            // if user enters an input convert to int and do math
            else
            {
                int num3 = Convert.ToInt32(num2);
                int answer = newMath.MathOperation(num1, num3);

                Console.WriteLine(num1 + " x " + num3 + " = " + answer);
            }

            Console.ReadLine();
        }
    }
}
