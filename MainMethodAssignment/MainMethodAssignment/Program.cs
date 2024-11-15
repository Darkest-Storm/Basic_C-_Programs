using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate MathMethods class
            MathMethods math1 = new MathMethods();

            // Call first method with an interger
            Console.WriteLine(math1.Math(7));

            // Call second method with a decimal
            Console.WriteLine(math1.Math(107.6m));

            // Call third method with a string
            Console.WriteLine(math1.Math("6"));

            Console.ReadLine();
        }
        
    }
}
