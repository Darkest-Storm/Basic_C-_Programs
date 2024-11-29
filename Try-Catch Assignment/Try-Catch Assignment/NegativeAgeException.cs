using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    public class NegativeAgeException : Exception
    {
        public NegativeAgeException()
            : base() { }
        public NegativeAgeException(string message)
            : base(message) { }
    }
}
