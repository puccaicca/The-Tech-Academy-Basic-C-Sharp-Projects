using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_MethodClassSubmission
{
    public class MathMethod
    {
        //// First method that takes an integer
        //public int MathOp(int number)
        //{
        //    return number + 9;
        //}
        //// Second method that takes a decimal
        //public int MathOp(decimal number)
        //{
        //    // Convert the decimal to an int to perform math operation
        //    int newnum = Convert.ToInt32(number);
        //    return newnum * 30; 
        //}
        //// Third Method that takes a string, converts to an integer, performs a math operation and returns the result
        //public int MathOp(string number)
        //{
        //    //Convert the string to an int to perform a math operation
        //    int newnum = Convert.ToInt32(number);
        //    return newnum / 2;

        // create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen.
        public int MathOp(int i, int j)
        {
            int result = i * j;
            return result;
        }
        public int MathOp(string i, string j)
        {
            
        }
    }
}

