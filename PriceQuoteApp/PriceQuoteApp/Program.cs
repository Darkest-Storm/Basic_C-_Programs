using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. The user must then be prompted for the package weight.
            Console.WriteLine("Please enter the package weight:");
            float pkgWeight = float.Parse(Console.ReadLine());

            // 3. If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            // 4. The user must then be prompted for the package width.
            Console.WriteLine("Please enter the package width:");
            float pgkWidth = float.Parse(Console.ReadLine());

            // 5. Then the package height.
            Console.WriteLine("Please enter the package height:");
            float pgkHeight = float.Parse(Console.ReadLine());

            // 6. Then the package length.
            Console.WriteLine("Please enter the package length:");
            float pgkLength = float.Parse(Console.ReadLine());

            // 7. If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
            float dimensions = pgkWidth + pgkHeight + pgkLength;

            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            // 8.Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
            float price = (pkgWeight * pgkWidth * pgkHeight * pgkLength) / 100;

            // 9.  The result of that calculation is the quote.
            // 10. Display the quote to the user as a dollar amount.
            Console.WriteLine("Your estimated total for shipping this package is: $" + price.ToString("F2"));
            1111111111111111111111
            Console.ReadLine();
        }
    }
}
