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
            //// Instantiate the MathMethod class
            // MathMethod math1 = new MathMethod();
            ////Call the furst method in the class, passing in an integer parameter
            //Console.WriteLine(math1.MathOp(9));
            ////Call the second method in the class, passing in a decimal parameter
            //Console.WriteLine(math1.MathOp(8.8m));
            ////Call the third method with a string parameter
            //Console.WriteLine(math1.MathOp("4"));
            //Console.ReadLine();

            // Instantiate the MathMethod class
            MathMethod math1 = new MathMethod();
            //Call the first method in the class, passing in two numbers
            Console.WriteLine(math1.MathOp(9, 8));
            //Call the method in the class, specifying the parameters by name
            Console.WriteLine(math1.MathOp("i", "j"));
            Console.ReadLine();
        }
    }
}
