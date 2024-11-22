using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employees.
            //At least two employees should have the first name “Joe”
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, firstName = "Joe", lastName = "Smith" },
                new Employee() { Id = 2, firstName = "Joe", lastName = "Stronghammer" },
                new Employee() { Id = 3, firstName = "Jerry", lastName = "Johnson" },
                new Employee() { Id = 4, firstName = "Joe", lastName = "Truemen" },
                new Employee() { Id = 5, firstName = "Joe", lastName = "Moe" },
                new Employee() { Id = 6, firstName = "Doris", lastName = "Want" },
                new Employee() { Id = 7, firstName = "Kevin", lastName = "Surmik" },
                new Employee() { Id = 8, firstName = "Jane", lastName = "Doe" },
                new Employee() { Id = 9, firstName = "Jane", lastName = "Smith" },
                new Employee() { Id = 10, firstName = "Jhon", lastName = "Smith"}
             };

            List<Employee> joes = new List<Employee>();
            //Using a foreach loop, create a new list of all employees
            //with the first name “Joe”.
            foreach(Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            // Perform the same action again, but this time with a lambda expression.
            List<Employee> joes2 = employees.Where(x => x.firstName == "Joe").ToList();

            // Using a lambda expression, make a list of all employees
            // with an Id number greater than 5
            List<Employee> over5 = employees.Where(x => x.Id > 5).ToList();

            // test the joes list uncomment below

            //foreach (Employee employee in joes)
            //{
            //    Console.WriteLine(employee.Id + " " + employee.firstName + " " + employee.lastName);
            //}
            //Console.ReadLine();

            // test the joes2 list uncomment below

            //foreach (Employee employee in joes2)
            //{
            //    Console.WriteLine(employee.Id + " " + employee.firstName + " " + employee.lastName);
            //}
            //Console.ReadLine();

            // test the over5 list uncomment below

            //foreach (Employee employee in over5)
            //{
            //    Console.WriteLine(employee.Id + " " + employee.firstName + " " + employee.lastName);
            //}
            //Console.ReadLine();
        }
    }
}
