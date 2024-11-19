using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sam = new Employee { firstName = "Sample", lastName = "Employee" };

            // use polymorphism to create a IQuittable object and use Quit() on it
            IQuittable quitSam = sam;
            quitSam.Quit();
            Console.ReadLine();
        }
    }
}
