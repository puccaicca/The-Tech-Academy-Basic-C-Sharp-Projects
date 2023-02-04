using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main()
        {
            // Title
            // Writes and prints the title and heading of the report
            Console.WriteLine("Academy of Learning Career College\nStudent Daily Report");
            Console.ReadLine();

            // Name 
            // Asks for their name and prints their output as a string
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            // Course
            // Asks for their course name and prints their output as string
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("You're on the " + course + " course");
            Console.ReadLine();

            // Page Number
            // Asks for the page number, converts their answer into a string and converts it into an int (number), and outputs it
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pgNumber = Convert.ToInt32(pageNumber);
            Console.WriteLine("You're on page: " + pgNumber);
            Console.ReadLine();

            // Help
            // Asks if they need help, converts their answer from a string to a boolean, and outputs it
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpStatus = Console.ReadLine();
            bool yourHelp = Convert.ToBoolean(helpStatus);
            Console.WriteLine("Help: " + helpStatus);
            Console.ReadLine();

            // Positive Experiences
            // Asks about their experiences, and outputs that string
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string poExp = Console.ReadLine();
            Console.WriteLine("You said: " + poExp);
            Console.ReadLine();

            // Feedback
            // Asks about their feedback, and outputs that string
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("Your feedback:  " + feedback);
            Console.ReadLine();

            // Study Hours
            // Asks about their study hours, converts the string into int (number), and outputs it with the string
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int studyHours = Convert.ToInt32(hours);
            Console.WriteLine("You studied for " + studyHours + " hours today");
            Console.ReadLine();

            // End Ment
            // Prints a nice ending message for the students
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();

            




        }
    }
}
