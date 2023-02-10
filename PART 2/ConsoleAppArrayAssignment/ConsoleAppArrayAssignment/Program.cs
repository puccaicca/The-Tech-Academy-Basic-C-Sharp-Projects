using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of strings
            string[] name = { "Lilian", "Karen", "Vivien", "Wendy" };
            bool Looping = true; // boolean to tell whether the loop continues

            while (Looping == true) // while the user hasn't chosen a valid index
            {
                Console.WriteLine("Please select an index of the Array from 0-3 to show a name");
                try // if this fails then the input is not valid
                {
                    int index = int.Parse(Console.ReadLine()); // receives input
                    Console.WriteLine(name[index]); // output the value
                    Console.ReadLine();
                    break; // loop will end once it gets valid input
                }
                catch // alerts the user the input is bad and to try again
                {
                    Console.WriteLine("Please select a valid index");
                }
            }
            

            // Array of intergers
            int[] numbers = { 8, 20, 50, 150, 200 };
            bool Loop2 = true; // boolean to tell whether the loop continues

            while (Loop2 == true) // while the user hasn't chosen a valid index
            {
                Console.WriteLine("Please select an index of the Array from 0-4 to show a number");
                try // if this fails then the input is not valid
                {
                    int numberIndex = int.Parse(Console.ReadLine()); // receives input
                    Console.WriteLine(numbers[numberIndex]); // ouput the value
                    Console.ReadLine();
                    break; // loop will ends once it gets valid input
                }
                catch // alerts the user the input is bad and to try again
                {
                    Console.WriteLine("Please select a valid index");
                }
            }


            // List of Strings
            List<string> stringList = new List<string>();
            stringList.Add("orange");
            stringList.Add("red");
            stringList.Add("blue");
            stringList.Add("green");
            stringList.Add("purple");

            // Asks user to select an index of the list
            Console.WriteLine("Please select an index from 0-4 to display a string from a list");

            int stringIndex = int.Parse(Console.ReadLine()); // receives the index number input
            Console.WriteLine(stringList[stringIndex]); // outputs the index value from the string list
            Console.ReadLine();
            
        }
    }
}
