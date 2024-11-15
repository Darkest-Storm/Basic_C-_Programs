using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate MathMethods
            MathMethods math = new MathMethods();

            // Get user to enter a number and pass it to DivideTwo method
            Console.WriteLine("Enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            math.DivideTwo(num1);



            // called overloaded method
            Console.WriteLine("Enter a second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            math.DivideTwo(num1,num2);

            // set up and call method with out parameters
            int stringLength = 0;
            string outParameter = "";

            Console.WriteLine("Enter a word: ");
            string one = Console.ReadLine();
            Console.WriteLine("Enter a second word: ");
            string two = Console.ReadLine();

            MathMethods.OutParameter(one, two, out outParameter, out stringLength);
            Console.WriteLine(outParameter);
            Console.WriteLine("The length of both words combined is: " + (stringLength - 1));

            // Call static class and method
            Console.WriteLine("Enter integer to by multiplied by 10");
            Console.WriteLine("The answer is: " + StaticClass.TimesTen(Convert.ToInt32(Console.ReadLine())));

            Console.ReadLine();
        }
    }
}
