using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Requirements
//1.The program must start by printing “Academy of Learning Career College”.
//2. The next line must be “Student Daily Report.”
//3. You must ask and save your data according to its proper data type and with clearly labeled variables. 
//4. The DR must contain the following questions:
//		a.What is your name ?
//      b.What course are you on?
//		c. What page number?
//		d. Do you need help with anything? Please answer “true” or “false”.
//		e. Were there any positive experiences you’d like to share? Please give specifics.
//		f. Is there any other feedback you’d like to provide? Please be specific.
//		g. How many hours did you study today?
//5. After all of the questions are asked, print, “Thank you for your answers. An Instructor will respond shortly. Have a great day!” This will be the end of the program.
//6. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. 


namespace Student_Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.The program must start by printing “Academy of Learning Career College”.
            //2. The next line must be “Student Daily Report.”
            Console.WriteLine("Academy of Learning Career College\nStudent Daily Report");

            //4. The DR must contain the following questions:
            //		a.What is your name ?
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            
            // b.What course are you on?
            Console.WriteLine("What course are you on?");
            String course = Console.ReadLine();
            
            // c.What page number?
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());

            // d.Do you need help with anything? Please answer “true” or “false”.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool helpBool = bool.Parse(help);

            // e. Were there any positive experiences you’d like to share? Please give specifics.
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperiences = Console.ReadLine();

            // f. Is there any other feedback you’d like to provide? Please be specific.
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // g. How many hours did you study today?
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);

            // After all of the questions are asked, print, “Thank you for your answers. An Instructor will respond shortly.Have a great day!” This will be the end of the program.
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
