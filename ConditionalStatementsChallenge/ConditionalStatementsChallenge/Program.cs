using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

            Console.WriteLine("Please input your name");
            string name = Console.ReadLine();

            if (name == "Lilian")
            {
                Console.WriteLine("Hey Lilian!!");
                Console.ReadLine();
            }
            else if (name == "Karen")
            {
                Console.WriteLine("What are you doing here, Karen!");
                Console.ReadLine();
            }
            else if (name == "Vivien") 
            {
                Console.WriteLine("Sup Viven?");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Who are you? Go away");
                Console.ReadLine();
            }

        }
    }
}
