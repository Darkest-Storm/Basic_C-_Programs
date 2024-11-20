using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    // This class represents an Employee with Id, FirstName, and LastName properties.
    public class Employee
    {
        // Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Overloading the '==' operator to compare two Employee objects
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Compare the Id properties of both Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overloading the '!=' operator to complement the '==' operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}