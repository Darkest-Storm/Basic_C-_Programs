using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate an Employee object with firstName “Sample” and lastName “Student”
            Employee sam = new Employee { firstName = "Sample", lastName = "Student" };

            // Call the SayName() method on the object.
            sam.SayName();
            Console.ReadLine();

        }
    }
}
