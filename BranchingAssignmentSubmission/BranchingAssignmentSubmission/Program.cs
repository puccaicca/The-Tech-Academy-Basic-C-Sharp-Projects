using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            // User inputs weight > converts to int 
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // if weight > 50, the program ends with the message
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express");
                Console.ReadLine();
            }

            // program continues
            else
            {
                // asks user for package width > converts to int
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                //asks user for package height > converts to int
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                // asks for package length > converts it to int 
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                // calculates the dimensions
                int dimensions = width + height + length;

                    // if dimensions is over 50, the program ends
                    if (dimensions > 50)
                    {
                        Console.WriteLine("Package too big to be shipped via Package Express.");
                        Console.ReadLine();
                    }
                    // program continues
                    else
                    {
                        // shipping calculation : mulitply the dimensions together, multiply product by weight, divide outcome by 100
                        decimal shipping = (height * width * length) * weight / 100.00m;
                        Console.WriteLine("Your estimated total for shipping this package is: $" + shipping + "\nThank you, have a great day!");
                        Console.ReadLine();
                    }
            }

        }
    }
}
