using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathMethods
    {
        //Create a math method that returns an integer
        public int Math (int number)
        {
            return number + 66;
        }

        // Create 2nd method same name, takes decimal and returns an int
        public int Math (decimal number)
        {
            // convert input to int to perform math
            int intNumber = Convert.ToInt32(number);
            return intNumber - 66;
        }

        // Create 3rd math method, takes a string and returns an int if possible
        public int Math (string number)
        {
            // convert the input string to an int to perform math
            int intNumber = Convert.ToInt32(number);
            return intNumber * 66;
        }
    }
}
