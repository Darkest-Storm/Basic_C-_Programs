using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for a number
            Console.WriteLine("Please enter a number");

            // log the number to a text file
            string num = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Kevin\Desktop\AOL Folder\C# and .NET Framework\Basic_C#_Programs\Input Assignment\log.txt", num);

            Console.WriteLine("You have logged: ");
            // print the text file back to the user
            Console.WriteLine(File.ReadAllText(@"C:\Users\Kevin\Desktop\AOL Folder\C# and .NET Framework\Basic_C#_Programs\Input Assignment\log.txt"));
            Console.ReadLine();
        }
    }
}
