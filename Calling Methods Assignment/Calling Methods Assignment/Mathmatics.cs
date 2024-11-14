using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    public class Mathmatics
    {
        // create three methods, each of which will take one integer parameter in and return an integer.
        // The methods should do some math operation on the received parameter.
        public static int TimesTen(int ten)
        {
            int timesTen = ten * 10;
            return timesTen;
        }
        public static int TimesHundred(int hundred)
        {
            int timesHundred = hundred * 100;
            return timesHundred;
        }
        public static int TimesThousand(int thousand)
        {
            int timesThousand = thousand * 1000;
            return timesThousand;
        }
    }
     
}
