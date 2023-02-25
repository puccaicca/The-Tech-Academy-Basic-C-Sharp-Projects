using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_ConsoleAppStringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> intList = new List<int> { 6, 90, 100, 200, 300, 400, 700, 900 };
            // Asks the user for a number to divide each number in the list by
            bool numValid = false;
            while (!numValid)
            {
                // Using a try/catch block to give error message
                try
                {
                    Console.WriteLine("\nEnter a number to divide the above list by: ");
                    float numDivide = float.Parse(Console.ReadLine());
                    // If statement to check if the user entered 0
                    if (numDivide == 0)
                    {
                        Console.WriteLine("Please enter a number other than 0.");
                    }
                    // Dividing each number in the list by the input
                    else
                    {
                        foreach (int num in intList)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                        }
                        numValid = true;
                    }
                }
                // Catch block to display error message for string input
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            // Message to let user know the program has exited to try/catch block
            Console.WriteLine("The program has exited the try/catch block.");
            Console.ReadLine();
        }
    }
}
