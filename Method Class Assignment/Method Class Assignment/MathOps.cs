using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    // Create the MathOps class
    class MathOps
    {
        // create a void method that takes two integers
        
        public void DoMathOps(int num1, int num2)
        {
            // do math on the first input while just displaying the second
            int answer = num1 + 66;
            Console.WriteLine("The result of adding 66 to " + num1 + " is: " + answer + "\nThe second number was: " + num2);

        }
    }
}
