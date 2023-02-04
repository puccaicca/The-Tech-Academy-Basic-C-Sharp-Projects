using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number to multiply by 50");
            string multi = Console.ReadLine();
            int multiply = Convert.ToInt32(multi);
            int math = 50;
            int multiplication = multiply * math;
            Console.WriteLine(multiply + " X 50 = " + multiplication);
            Console.ReadLine();

            Console.WriteLine("Please input a number to add by 25");
            string add = Console.ReadLine();
            int addi = Convert.ToInt32(add);
            int addnumber = 25;
            int addition = addi + addnumber;
            Console.WriteLine(addi + " + 25 = " + addition);
            Console.ReadLine();

            Console.WriteLine("Please input a number to divide by 12.5");
            string div = Console.ReadLine();
            int divi = Convert.ToInt32(div);
            double divnumber = 12.5;
            double divison = divnumber / (double)divi;
            Console.WriteLine(divi + " / 12.5 = " + divison);
            Console.ReadLine();

            Console.WriteLine("Please input a number and check to see if it's greater than 50");
            string comp = Console.ReadLine();
            int compnum = Convert.ToInt32(comp);
            int greater = 50;
            bool trueorfalse = compnum > greater;
            Console.WriteLine(trueorfalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Please input a number to divide by 7 to get the remainder");
            string yourRem = Console.ReadLine();
            int yourRemains = Convert.ToInt32(yourRem);
            int remCalc = 7;
            int remainder = yourRemains % remCalc;
            Console.WriteLine("The remainder of " + yourRemains + " is " + remainder);
            Console.ReadLine();


        }
    }
}
