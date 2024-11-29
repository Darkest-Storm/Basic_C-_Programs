using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    public class AgeZeroException : Exception
    {
        public AgeZeroException()
            : base() { }
        public AgeZeroException(string message)
            : base(message) { }
    }
}
