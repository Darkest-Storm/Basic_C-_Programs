using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class MathOps
    {
        //create a method that takes two integers as parameters.
        //Make one of them optional.
        //Have the method do a math operation and return an integer result.
        public int MathOperation (int i, int j = 1)
        {
            int answer = i * j;
            return answer;
        }
    }
}
