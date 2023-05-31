using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        struct Number
        {
            public decimal Amount;
        }

        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 200;
            Console.WriteLine("Struct Amount is: " + number.Amount);
            Console.ReadLine();
        }
    }
}
