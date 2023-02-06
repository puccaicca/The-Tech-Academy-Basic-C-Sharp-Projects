using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ternary operator allows you to write a single line of code that will check for a condition and, depending on the outcome, execute another portion of code
            int num1 = 77;
            int num2 = 12;

            string result = num1 > num2 ? "num 1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
