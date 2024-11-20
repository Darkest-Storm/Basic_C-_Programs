using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects with different Ids and names
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded '==' operator
            bool areEqual = employee1 == employee2;

            // Display the comparison result
            if (areEqual)
            {
                Console.WriteLine("The two employees are equal.");
            }
            else
            {
                Console.WriteLine("The two employees are not equal.");
            }
            Console.ReadLine();
        }
    }
}
