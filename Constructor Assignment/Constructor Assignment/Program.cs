using System;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable
            const string Welcome = "Welcome to the Constructor Assignment";
            Console.WriteLine(Welcome);

            // create a variable using var
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter your occupation or press enter:");
            var occ = Console.ReadLine();

            // calling constructor based on if user entered an occupation or just use default
            Person person = string.IsNullOrWhiteSpace(occ) ? new Person(name) : new Person(name, occ);

            Console.ReadLine();
        }
    }
}
