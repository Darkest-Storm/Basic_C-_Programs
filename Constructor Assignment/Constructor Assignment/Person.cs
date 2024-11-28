using System;

namespace Constructor_Assignment
{
    public class Person
    {
        public string Name { get; set; }
        public string Occupation { get; set; }

        // Chain two constructors together
        // Base constructor with all parameters
        public Person(string name, string occupation)
        {
            Name = name;
            Occupation = occupation;
            Console.WriteLine("Created person {0} with Occupation: {1}", name, occupation);
        }

        // Constructor chaining with default occupation
        public Person(string name) : this(name, "Default-Unemployed")
        {
        }
    }
}

