using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();


            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++) // int j is 0 (starts at 0) ; do the loop as long as j is less than 4 index; after for loop add one to j
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]); // outputs Jesse
            // can also remove the if statement and inputs all names from the array
            //    }
            //}
            //Console.ReadLine();


            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}
            //Console.ReadLine();




            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name); //prints all names in list

            //}
            //Console.ReadLine();


            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>(); // empty list at the start
            foreach (int score in testScores)
            {
                if (score > 85) // if score is greater than 85
                {
                    passingScores.Add(score); // will add that score into the passing score list
                }
            }
            Console.WriteLine(passingScores.Count); // counts how many passing scores there are in the list
            Console.ReadLine();
        }
    }
}
