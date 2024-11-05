using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Array_Assignment
{
    class Program
    {
        static void Main()
        {
            //1. Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            string[] stringArray = new string[] {"Hello", "Good Day", "Hi", "Greetings", "Welcome" };

            //2. Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] intArray = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256 };

            //4. Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
            List<string> stringList = new List<string> {"Goodbye", "See you next time", "Bye-Bye" };


            //Ask the user to select an index and display what is at that index
            //Add in a message that displays when the user selects an index that doesn’t exist.
            //for string array

            Console.WriteLine("Please select a number ranging from 0 to 4, to receive your greeting");
            int indexStringArray = Convert.ToInt32(Console.ReadLine());
            bool validStringArray = false;

            while (!validStringArray)
            {
                try
                {
                    Console.Write(stringArray[indexStringArray]);
                    validStringArray = true;
                }
                catch
                {
                    Console.WriteLine("That number is not within the range of 0 to 4, Please try again");
                    indexStringArray = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Ask the user to select an index and display what is at that index
            //Add in a message that displays when the user selects an index that doesn’t exist.
            // for int array
            Console.WriteLine("\n\nPlease select a number ranging from 0 to 8");
            int indexIntArray = Convert.ToInt32(Console.ReadLine());
            bool validIntArray = false;

            while (!validIntArray)
            {
                try
                {
                    Console.Write("your lucky number is: " + intArray[indexIntArray]);
                    validIntArray = true;
                }
                catch
                {
                    Console.WriteLine("That number is not within the range of 0 to 8, Please try again");
                    indexIntArray = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Ask the user to select an index and display what is at that index
            //Add in a message that displays when the user selects an index that doesn’t exist.
            // for string list
            Console.WriteLine("\n\nPlease select a number ranging from 0 to 2");
            int indexStringList = Convert.ToInt32(Console.ReadLine());
            bool validStringList = false;

            while (!validStringList)
            {
                try
                {
                    Console.Write(stringList[indexStringList]);
                    validStringList = true;
                 
                }
                catch
                {
                    Console.WriteLine("That number is not within the range of 0 to 2, Please try again");
                    indexStringList = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.ReadLine();


        }
    }
}
