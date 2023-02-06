using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operator Challenge using the != operator (not equal)
            Console.WriteLine("Write your name please");
            string name = Console.ReadLine();
            

            if (name != "Lilian")
            {
                Console.WriteLine("Why you here");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Welcome back, Lilian!");
                Console.ReadLine();
            }
        }
    }
}
