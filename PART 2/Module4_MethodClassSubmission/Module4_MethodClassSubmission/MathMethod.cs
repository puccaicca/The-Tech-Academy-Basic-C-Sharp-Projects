using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_MethodClassSubmission
{
    public class MathMethod
    {
        // create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen.
        public void MathOp(int num1, int num2)
        {
            int operation = num1 * 60;
            Console.WriteLine("The first number you entered is " + num1 + " which is * by 60 " + "and the Result = " + operation);
            Console.WriteLine("The second number you entered is  " + num2 + " and there is no operation required for this");
        }
    }
}

