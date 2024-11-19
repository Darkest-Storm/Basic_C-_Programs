using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    //Make an employee class that inherits from Person
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        // implement SayName()
        public override void SayName()
        {
            Console.Write("Name: " + firstName + " " + lastName);
        }

        // implement Quit() in anyway
        public void Quit()
        {
            SayName();
            Console.Write(" has left the company");
        }
    }
}
