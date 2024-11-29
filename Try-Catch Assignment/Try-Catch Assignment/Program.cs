using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;

            while (!valid)
            {                            
                // Ask user for their age
                Console.WriteLine("Please enter your age: ");

                // Exceptions must be handled using “try/catch.”
                try 
                {
                    int age = Convert.ToInt32(Console.ReadLine());

                    // display appropriate error message if user enters zero
                    if (age == 0)
                    {
                        throw new AgeZeroException();
                    }

                    // display appropriate error message if user enters negative age
                    if (age < 0)
                    {
                        throw new NegativeAgeException();
                    }

                    // Display the year user was born
                    DateTime year = DateTime.Now.AddYears(-age);
                    int yearBorn = year.Year;

                    Console.WriteLine("You were born in the year: " + yearBorn);
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter only digits, and no decimals");
                    valid = false;    
                }
                // display appropriate error message if user enters zero
                catch (AgeZeroException)
                {
                    Console.WriteLine("Age can't be zero");
                }
                // display appropriate error message if user enters negative age
                catch (NegativeAgeException)
                {
                    Console.WriteLine("Age can't be negative");
                }

                // Display a general message if an exception was caused by anything else.
                catch (Exception)
                {
                    Console.WriteLine("There was an error, Please contact your System Administrator");
                    Console.ReadLine();
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
