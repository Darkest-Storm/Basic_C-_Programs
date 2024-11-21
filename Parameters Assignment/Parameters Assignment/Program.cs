using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate an Employee object with type “string” as its generic parameter.
            // Assign a list of strings as the property value of Things.
            Employee<string> Sam1 = new Employee<string>();
            Sam1.Things = new List<string>();

            Sam1.Things.Add("Hello");
            Sam1.Things.Add("World");

            //Instantiate an Employee object with type “int” as its generic parameter.
            //Assign a list of integers as the property value of Things.
            Employee<int> Sam2 = new Employee<int>
            { 
                Things = new List<int> { 5, 10, 15, 20 } 
            };

            //Create a loop that prints all of the Things to the Console.
            foreach (string String in Sam1.Things)
            {
                Console.WriteLine(String);
            }

            foreach (int Int in Sam2.Things)
            {
                Console.WriteLine(Int);
            }
            Console.ReadLine();
        }
    }
}
