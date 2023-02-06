using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOutputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your age");
            string age = Console.ReadLine();
            int yourage = Convert.ToInt32(age);
            Console.WriteLine("You're " + yourage + " years old");
            Console.ReadLine();

            if (yourage <= 20)
            {
                Console.WriteLine("You may not purchase that beer");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Yes, please buy this beer");
                Console.ReadLine();
            }


            Console.WriteLine("Please input your age");
            string age2 = Console.ReadLine();
            int yourage2 = Convert.ToInt32(age2);
            Console.WriteLine("You're " + yourage2 + " years old");
            Console.ReadLine();

            if (yourage2 >= 60)
            {
                Console.WriteLine("Be careful of your health before you drink this beer!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enjoy this beer!");
                Console.ReadLine();
            }
        }
    }
}
