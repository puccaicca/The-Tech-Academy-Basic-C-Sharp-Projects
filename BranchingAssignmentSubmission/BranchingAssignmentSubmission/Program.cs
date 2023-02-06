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
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below.");
            Console.ReadLine();

            // User inputs weight > converts to int 
            Console.WriteLine("Please enter the package weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            string weightResult = weight < 50 ? "Your package is not too heavy." : "Package too heavy to be shipped via Package Express. Have a good day."; // if weight is over 50 the program ends 
            Console.WriteLine(weightResult);
            Console.ReadLine();

            // asks for the width > converts it to int 
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // asks for the height > converts it to int 
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // asks for the length > converts it to int 
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // calculates the dimensions, program ends if total is over 50
            string dimensions = width + height + length < 50 ? "Your package is shippable." : "Package too big to be shipped via Package Express.";
            Console.WriteLine(dimensions);
            Console.ReadLine();

            // shipping calculation : mulitply the dimensions together, multiply product by weight, divide outcome by 100
            decimal shipping = (height * width * length) * weight / 100;  
            Console.WriteLine("Your estimated total for shipping this package is: $" + shipping + "\nThank you, have a great day!");
            Console.ReadLine();

        }
    }
}
