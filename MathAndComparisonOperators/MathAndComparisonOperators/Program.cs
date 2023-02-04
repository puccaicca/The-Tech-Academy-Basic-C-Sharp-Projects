using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adding
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            // Subtraction
            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            // Multiplication
            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            // Division
            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            // Remainder (Modulus Operator)
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();


            // Comparison Operators

            // Boolean
            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            // Boolean
            int roomTemperature = 70;
            int currentTemperature = 70;

            //bool isWarm = currentTemperature <= roomTemperature; // less than or equal
            //bool isWarm = currentTemperature == roomTemperature; // equality
            bool isWarm = currentTemperature != roomTemperature; // not equal
            Console.WriteLine(isWarm);
            Console.ReadLine();

        }
    }
}
