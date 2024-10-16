using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // two line intro to the program
            Console.WriteLine("Anonymous Income Comparison Program \nPerson 1");


            // grab person 1 hourly rate and weekly hours from the user
            Console.WriteLine("What is the hourly rate?");
            string hourRate1 = Console.ReadLine();

            Console.WriteLine("How many hours worked per week?");
            string hours1 = Console.ReadLine();

            // grab person 2 hourly rate and weekly hours from the user
            Console.WriteLine("What is the hourly rate>");
            string hourRate2 = Console.ReadLine();

            Console.WriteLine("How many hours worked per week?");
            string hours2 = Console.ReadLine();

            // calculate the salery and do type conversions
            decimal salary1 = decimal.Parse(hourRate1) * Convert.ToInt32(hours1) * 52;

            decimal salary2 = decimal.Parse(hourRate2) * Convert.ToInt32(hours2) * 52;

            // show both salaries and then say if person 1 makes more or less in a true or false manor per reqs
            Console.WriteLine("Person 1 has a salary of: " + salary1);

            Console.WriteLine("Person 2 has a salary of: " + salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);


            Console.ReadLine();
        }
    }
}
