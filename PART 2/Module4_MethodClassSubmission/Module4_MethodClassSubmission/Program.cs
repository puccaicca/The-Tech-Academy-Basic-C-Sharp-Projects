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
            MathMethod MathMethod = new MathMethod();

            Console.WriteLine("Enter the First Number");
            int userFirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int userScondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("********** Method call by passing two number! ***************");
            MathMethod.MathOp(userFirstNum, userScondNum);
            Console.WriteLine("");

            Console.WriteLine("********** Method call specifying the parameters by name ***************");
            MathMethod.MathOp(num2: userScondNum, num1: userFirstNum);

            Console.ReadLine();
        }
    }
}
