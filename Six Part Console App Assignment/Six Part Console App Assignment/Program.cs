using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1
            // create a one-dimensional array of strings
            string[] sentenceStart =
            {
                "This is the beginning of ",
                "Once upon a time, in the land of ",

            };

            // Ask the user to input some text
            List<string> userText = new List<string>();

            Console.WriteLine("Please enter a subject of any kind: ");
            userText.Add(Console.ReadLine());

            Console.WriteLine("Please enter a place real or not: ");
            userText.Add(Console.ReadLine());

            // A loop that iterates through each string in the array and
            // adds the user's text input to the end of each string.

            for (int i = 0; i < sentenceStart.Length; i++)
            {
                sentenceStart[i] += userText[i];

                // uncomment next 2 lines for testing purposes only
                //Console.WriteLine(sentenceStart[i]);
                //Console.ReadLine();                
            };

            // Create a 2nd loop that prints off each string in the array 1 at a time

            for (int i = 0; i < sentenceStart.Length; i++)
            {

                Console.WriteLine(sentenceStart[i]);

                // Part 2
                //Create an infinite loop uncomment i-- to create
                //fixed the infinite loop by commenting out i--
                //i--;
            };

            Console.WriteLine("\n");

            // Part 3

            // Make a loop that uses <

            Console.WriteLine("Do you think coding can be fun?");

            StringBuilder ya = new StringBuilder();
            ya.Append("Y");
            while (ya.Length < 5)
            {
                ya.Append("a");
            }

            ya.Append("!");
            Console.ReadLine();
            Console.WriteLine(ya);
            Console.ReadLine();



            // Make another loop using <=

            Console.WriteLine("Do you think coding is bad?");

            StringBuilder no = new StringBuilder();
            no.Append("N");
            while (no.Length <= 5)
            {
                no.Append("o");
            }

            no.Append("!");
            Console.ReadLine();
            Console.WriteLine(no);
            Console.ReadLine();

            Console.WriteLine("\n");

            // Part 4
            // Make a list of strings where each string is unique

            List<string> provinces = new List<string> {
                "Alberta",
                "British Columbia",
                "Manitoba",
                "New Brunswick",
                "Newfoundland and Labrador",
                "Northwest Territories",
                "Nova Scotia",
                "Nunavut",
                "Ontario",
                "Prince Edward Island",
                "Quebec",
                "Saskatchewan",
                "Yukon",
            };

            // Have the user input a search term

            Console.WriteLine("Please enter the full name of a Canadian Provence: ");
            bool searchProvinceDone = false;
            int index = 0;
            bool matchFound = false;

            // a loop that will give the user the index of the search term if found
            while (!searchProvinceDone)
            {
                string searchProvince = Console.ReadLine();
                int i2 = -1;

                foreach (string province in provinces)
                {
                   
                    if (string.Equals(province, searchProvince, StringComparison.OrdinalIgnoreCase))
                    {
                        
                        index = i2 + 1;
                        matchFound = true;
                    }
                    i2++;
                }

                // Add code that tells the user if there's no match
                if (matchFound == false)
                {
                    Console.WriteLine("That is not a Canadian Province. Please enter again:");
                }

                // Add code to the loop that stops it once a match is found
                else
                {
                    searchProvinceDone = true;
                }

            }

            Console.WriteLine("The index for the Province entered is: " + index);
            Console.WriteLine("\n");
            
            // Part 5

            // A list of strings with at least 2 identical strings
            List<string> names = new List<string> { "Kevin", "Bob", "Kevin", "Jerry" };

            // ask user to to enter a search term

            Console.WriteLine("Please enter a name to search for: ");
            string searchName = Console.ReadLine();

            // make a loop that searches for the search term and gives all indices of it (including duplicates)
            bool nameFound = false;

            for (int i=0; i < names.Count; i++)
            {
                if (searchName == names[i])
                {
                    Console.WriteLine(searchName + " Can be found at index: " + i);
                    nameFound = true;
                }
            }

            // add code that tells the user if there's no matches (no need to let user try again)
            if (!nameFound)
            {
                Console.WriteLine(searchName + " is not found");
            }

            Console.WriteLine("\n");

            //Part 6

            Console.WriteLine("Processing roster and checking for duplicates");
            // Create a list of strings that has at least two identical strings in the list.
            List<string> names2 = new List<string> { "Christine", "Chris", "Bob", "Chris", "Kevin" };

            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> dupNames = new List<string>();

            foreach (string name in names2)
            {
                if (dupNames.Contains(name))
                {
                    Console.WriteLine(name + " is a duplicate");
                }
                else
                {
                    Console.WriteLine(name + " is unique");
                }
                dupNames.Add(name);
            }

            Console.ReadLine();


        }
    }
}
