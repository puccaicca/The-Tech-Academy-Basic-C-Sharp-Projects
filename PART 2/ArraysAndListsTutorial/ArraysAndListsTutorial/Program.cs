using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            // LISTS
            //List<int> intList = new List<int>();
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Lilian");
            intList.Remove("Lilian");
            //intList.Add(4); // 
            //intList.Add(10);
            //intList.Remove(10);

            //Console.WriteLine(intList[0]); // outputs 4
            Console.WriteLine(intList[0]); // outputs "Hello"
            Console.ReadLine();

            
            // ARRAYS
            //int[] numArray = new int[5]; // [5] declares the length of the array
            //numArray[0] = 5; // the numbers specified in the array order of [0]
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 50000, 600, 2300 };

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 }; // fastest way to make the array

            //numArray2[5] = 650; // changes the number in the array

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();
        }
    }
}
