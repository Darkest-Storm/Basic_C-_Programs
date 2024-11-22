using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        // Create a struct called Number and give it the property “Amount”
        // have it be of data type decimal.
        struct Number
        {
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            //create an object of data type Number and assign an amount to it.
            Number num1;
            num1.Amount = 66.77m;

            // Print Amount to the console.
            Console.WriteLine(num1.Amount);
            Console.ReadLine();
        }
    }
}
