using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // print current date and time 
            Console.WriteLine("\nThe date and time at this moment is: " + DateTime.Now);

            // ask user for a number
            Console.WriteLine("\nPlease provde a number to see what time it will be in that many hours: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // print the time plus num in hours added to time
            Console.WriteLine("In " + num + " hours it will be : " + DateTime.Now.AddHours(num));

            Console.ReadLine();
        }
    }
}
