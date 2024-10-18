using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Insurance_Approval
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome any users to the application
            // grab their age
            // convert age to int
            // show the user what they entered
            Console.WriteLine("Welcome to car insurance application");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The age entered was: " + age);

            // ask user to answer yes or no to if they've had a DUI
            // convert answer to lower case
            // display DUI status entered
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower();
            bool dui = answer == "yes";
            Console.WriteLine("The entered DUI status is: " + dui);

            // get # speeding tickets from user and convert to int
            // confirm to the user what was entered
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered number of speeding tickets was: " + tickets);

            // using boolean logic infrom user if what they entered qualifies for insurance
            // a.Applicants must be over 15 years old.
            // b.Applicants must not have any DUI’s.
            // c.Applicants must not have more than 3 speeding tickets.
            Console.WriteLine("Are you qualified for insurance?");
            bool qualified = (age > 15) && !dui && (tickets <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();


        }
    }
}
