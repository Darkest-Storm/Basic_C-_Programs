using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    // Create an abstract person class
    // with two string properties firstName and lastName
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        // make a method SayName()
        public abstract void SayName();
    }
}
