using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // weeks in the year worked
            decimal weeks = 48;

            // Person 1
            // declaring the hourly rate and hours per week and prints them out
            Console.WriteLine("Person 1");
            decimal Rate1 = 18.00m;
            decimal Hours1 = 30;
            Console.WriteLine("Hours worked per week:  $" + Rate1);
            Console.WriteLine("Hourly Rate: " + Hours1 + " hours");
            Console.ReadLine();

            // Person 2
            // declaring the hourly rate and hours per week and prints them out
            Console.WriteLine("Person 2");
            decimal Rate2 = 20.00m;
            decimal Hours2 = 35;
            Console.WriteLine("Hours worked per week:  $" + Rate2);
            Console.WriteLine("Hourly Rate: " + Hours2 + " hours");
            Console.ReadLine();

            // Annual Salary of Person 1
            // Multiples the rate, hours, and work weeks = salary
            Console.WriteLine("Annual salary of Person 1:");
            decimal salPerson1 = Rate1 * Hours1 * weeks;
            Console.WriteLine(salPerson1);
            Console.ReadLine();

            // Annual Salary of Person 2
            // Multiples the rate, hours, and work weeks = salary
            Console.WriteLine("Annual salary of Person 2:");
            decimal salPerson2 = Rate2 * Hours2 * weeks;
            Console.WriteLine(salPerson2);
            Console.ReadLine();

            // True or False if Person 1 makes more than Person 2
            // Comparing the salary to see if person 1 makes more or not
            Console.WriteLine("Person 1 makes more money than Person 2");
            bool trueOrFalse = salPerson1 > salPerson2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}
