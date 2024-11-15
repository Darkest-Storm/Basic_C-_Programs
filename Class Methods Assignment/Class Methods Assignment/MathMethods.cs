using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Assignment
{
    class MathMethods
    {
        // Create a void method that divides by 2 and outputs an int
        public void DivideTwo(int num)
        {
            int result = num / 2;
            Console.WriteLine(num + " divided by 2 = " + result);
        }

        // make an overloaded method
        public void DivideTwo(int num, int num2)
        {
            int num3 = num + num2;
            int result = num3/ 2;
            Console.WriteLine(num3 + " divided by 2 = " + result);
        }

        // Create a method with outparameters
        public static string OutParameter (string one,string two, out string outParameter, out int stringLength)
        {
            outParameter = one + " " + two;
            stringLength = outParameter.Length;
            return outParameter;

        }

    }
}
