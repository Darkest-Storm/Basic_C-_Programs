using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOps class
            MathOps mathOps = new MathOps();

            // Call the method, passing two numbers
            mathOps.DoMathOps(8, 98);

            // Call the method, specifying parameters by name
            mathOps.DoMathOps(num1: 5, num2: 10);

            Console.ReadLine();
        }
    }
}
