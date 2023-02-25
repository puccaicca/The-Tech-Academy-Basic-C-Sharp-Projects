using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1

            // Array of strings (one-dimensional)
            //string[] colors = { "Orange", "Yellow", "Green", "Blue", "Purple" };

            //// Asks user to input some text
            //Console.WriteLine("Please add a color to the array");
            //string addColor = Console.ReadLine();

            //// Loop that iterates through each string and adds the user's text input to the end of each string
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    colors[i] = colors[i] + addColor;
            //}

            //// Second loop prints all strings in the array one at a time
            //foreach (string color in colors)
            //{
            //    Console.WriteLine(color);
            //}
            //Console.ReadLine();

            string[] wordstart =
            {
                "Welcome to The ",
                "I'm Principal, ",
                "Our goal is to provide our students with a "
            };
            string[] wordend =
            {
                " Academy.",
                ".",
                " learning experience."
            };

            List<string> responses = new List<string>();
            //Ask the user to input some text.
            Console.WriteLine("Please enter a noun:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter the name of someone infamous:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter an adjective");
            responses.Add(Console.ReadLine());
            //Create a loop that goes through each string in the Array, adding the user's text to the string.
            for (int i = 0; i < wordstart.Length; i++)
            {
                wordstart[i] += responses[i];
                Console.WriteLine(wordstart[i] + wordend[i]);
            }
            Console.ReadLine();
            Console.WriteLine("The strings we used:");
            //Then crate a loop that prints off each string in the Array on a seperate line.
            for (int i = 0; i < wordstart.Length; i++)
            {
                Console.WriteLine(wordstart[i] + wordend[i]);
            }
            Console.ReadLine();


            // PART 2

            // Infinite Loop
            int num = 0;

            while (num < 10) // only goes up to 0-9
            {
                Console.WriteLine(num);
                num = num + 1; // adds 1 to each num, remove this for infinite loop of 0's
            }
            Console.ReadLine();


            // PART 3

            // Loop using the < operator
            int[] testscores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for (int i = 0; i < testscores.Length; i++)
            {
                if (testscores[i] < 85)
                {
                    Console.WriteLine("passing test score: " + testscores[i]);
                }
            }
            Console.ReadLine();

            // Loop using the <= operator
            int[] testscores2 = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for (int i = 0; i < testscores2.Length; i++)
            {
                if (testscores2[i] <= 85)
                {
                    Console.WriteLine("passing test score: " + testscores2[i]);
                }
            }
            Console.ReadLine();


            // PART 4

            // A list of strings where each item in the list is unique
            List<string> teams = new List<string>() {  "Bucks", "Raptors", "Celtics", "Heat", "Pacers", "76ers", "Nets", "Magic",
                "Wizards", "Hornets", "Bulls", "Knicks", "Pistons", "Hawks", "Cavaliers" };
            Console.WriteLine("NBA Eastern Conference Standings");
            //Asks the user to input text to search for in the List
            Console.WriteLine("Enter team name:");
            int standing = 0;
            bool isValid = false;
            int index = 0;
            //Create a loop that ierates through the list and then displays the index of the array that contains matching text on the screen.
            while (!isValid)
            {
                int i2 = 0;
                string teamrequest = Console.ReadLine();
                foreach (string team in teams)
                {
                    if (teamrequest == team)
                    {
                        standing = i2 + 1;
                        index = i2;
                    }
                    i2++;
                }
                //Add code to that above loop that tells a user if they put in text that isn't in the List.
                if (standing == 0)
                {
                    Console.WriteLine("That is not a valid team name. Enter again:");
                }
                //Add code to that above loop that stops it from executing it from executing once a match has been found.
                else
                {
                    isValid = true;
                }
            }


            Console.WriteLine("Processing... Index is: " + index + ". So...");
            Console.WriteLine("Standing is: " + standing);
            Console.ReadLine();

            // PART 5
            // Create a List of strings that has at least two identical strings in the List.
            List<string> tables = new List<string>() { "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "Taken" };
            Console.WriteLine("Welcome to Swell Taco! \nDue to COVID-19 we have a computerized check-in.\nIf you have a reservation type " +
                "\"Reserved\".\nIf you are joining a party that is already here type \"Taken\".\nOtherwise type \"Vacant\".");
            //Asks the user to select text to search for in the List.
            Console.WriteLine("Enter selection:");
            string selection = Console.ReadLine();
            while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
            {
                //Add code that tells a user if they put in text that isn't in the List.
                Console.WriteLine("Please enter one of the 3 choices:");
                selection = Console.ReadLine();
            }
            Console.WriteLine("The tables that match your selection are numbered:");
            //Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
            for (int i3 = 0; i3 < tables.Count; i3++)
            {
                if (selection == tables[i3])
                {
                    Console.WriteLine(i3);
                }
            }
            Console.ReadLine();

            // PART 6
            // Create a List of strings that has at least two identical stirngs in the List.
            List<string> names = new List<string>() { "Bob", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary" };
            List<string> repeatCheck = new List<string>();
            Console.WriteLine("Class Roster:");
            //Create a foreach loop that evaluates each item in the List, and displays a message showing the string and whether or not it has already appeared in the list.
            foreach (string name in names)
            {
                Console.WriteLine(name);
                if (repeatCheck.Contains(name))
                {
                    Console.WriteLine("This name has been repeated. \nUse last name initial when referring to this student.");
                }
                else
                {
                    Console.WriteLine("This name has not been repeated.");
                }
                repeatCheck.Add(name);
            }
            Console.ReadLine();
        }
    }
}

