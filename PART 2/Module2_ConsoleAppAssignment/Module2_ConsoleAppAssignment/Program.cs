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
            string[] colors = { "Orange", "Yellow", "Green", "Blue", "Purple" };

            // Asks user to input some text
            Console.WriteLine("Please add a color to the array");
            string addColor = Console.ReadLine();

            // Loop that iterates through each string and adds the user's text input to the end of each string
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = colors[i] + addColor;
            }

            // Second loop prints all strings in the array one at a time
            foreach (string color in colors)
            {
                Console.WriteLine(color);
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
            List<string> furnitures = new List<string>() { "couch", "desk", "bed", "dresser", "coat rack", "mirror", "chair" };

            // Asks user to input text to search for in the list
            Console.WriteLine("Which type of furniture are you looking for?");
            bool isValid = false;
            int index = 0;
            


            // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen
            while (!isValid)
            {
                int i2 = 0;
                string askFurniture = Console.ReadLine();
                foreach (string furniture in furnitures)
                {
                    if (askFurniture == furniture)
                    {
                        index = i2;
                    }
                    i2++;
             
                    
                }
                
               
            }
            Console.WriteLine("Index is: " + index);
            Console.ReadLine();

        }
    }
}
