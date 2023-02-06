using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints the Form TItle
            Console.WriteLine("Car Insurance Approval Inquiry Form");
            Console.ReadLine();

            // Asks for their age > convert to string to int(number) > Prints their age
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int yourage = Convert.ToInt32(age);
            Console.WriteLine("You're " + yourage + " years old");
            Console.ReadLine();

            // Asks if they had a DUI > convert string to boolean > prints their answer
            Console.WriteLine("Have you ever had a DUI? Please input \"true\" or \"false\" ");
            string dui = Console.ReadLine();
            bool trueOrFalse = Convert.ToBoolean(dui);
            Console.WriteLine("Your answer: " + trueOrFalse);
            Console.ReadLine();

            // Asks how many speeding tickets they have > converts string to int(number) > prints answer
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int spTickets = Convert.ToInt32(tickets);
            Console.WriteLine("You have " + spTickets + " speeding tickets");
            Console.ReadLine();

            // Creates a boolean equation > age over 15, no dui, less than 3 speeding tickets > only prints true if those answers match
            Console.WriteLine("Qualified?");
            bool approval = (yourage >= 16 && trueOrFalse != true && spTickets < 4);
            Console.WriteLine(approval);
            Console.ReadLine();
        }
    }
}
