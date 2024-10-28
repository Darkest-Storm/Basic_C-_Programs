using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a while loop
            int count = 1;

            while (count < 11) // continues loop until it runs the 10th time (counter hits 11)
            {
                Console.WriteLine("We are inside a while loop at a count of: " + count + "/10");
                count++; // This adds one to count each time
            }

            // This is a do while loop
            int counting = 1;
            do
            {
                Console.WriteLine("We are inside a do while loop at a count of: " + counting + "/5");
                counting++; // This adds one to count each time
            }
            while (counting < 6); // the loop will run until counter hits 6

            Console.ReadLine();
        }
    }
}
