using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        //Create an enum for the days of the week.
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            bool isvalid = false;
            while (!isvalid)
            {  
                // use try/catch block and have it print "Please enter an actual day of the week.”
                // to the console if an error occurs.
                try
                {
                    //Prompt the user to enter the current day of the week.
                    Console.WriteLine("Please enter the current day of the week (no abbreviations): ");
                    string dayIn = Console.ReadLine();

                    //Assign the value to a variable of that enum data type you just created.
                    DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), dayIn, true);
                    Console.WriteLine("Have a great " + day);
                    Console.ReadLine();
                    isvalid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }            
        }
    }
}
