using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathMethod class
             MathMethod math1 = new MathMethod();
            //Call the method in the class, passing in two numbers
            Console.WriteLine(math1.MathOp(7, 9));
            //Call the method in the class, specifying the parameters by name
            Console.WriteLine(math1.MathOp("7"));
            Console.ReadLine();
        }
    }
}
