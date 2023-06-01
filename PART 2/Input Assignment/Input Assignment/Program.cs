using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite number?");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\heart\Logs\log2.txt", number);
          
        }
    }
}
