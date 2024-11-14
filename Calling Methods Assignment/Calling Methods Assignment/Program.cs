using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                //ask the user what number they want to do the math operations on
                Console.WriteLine("What number would you like to do math on?");
                int userMath = Convert.ToInt32(Console.ReadLine());

                //Call each method in turn, passing the user input
                Console.WriteLine(userMath + " Times 10 = " + Mathmatics.TimesTen(userMath));
                Console.WriteLine(userMath + " Times 100 = " + Mathmatics.TimesHundred(userMath));
                Console.WriteLine(userMath + " Times 1000 = " + Mathmatics.TimesThousand(userMath));

                Console.ReadLine();
            }
            catch (FormatException)
            {
                    Console.WriteLine("Next time please only enter a whole number");
                    Console.ReadLine();
            }
        }
    }
}
