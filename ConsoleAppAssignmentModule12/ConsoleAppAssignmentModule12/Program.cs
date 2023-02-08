using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentModule12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks them to guess my fave number
            Console.WriteLine("Guess my favorite number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guess = number == 8; // boolean must be 8 to be true
            
            do // do loop (must do loop once)
            {
                switch (number) // switch cases, will do the code if they guess that number(case)
                {
                    case 20:
                        Console.WriteLine("You guessed 20. Try again.");
                        Console.WriteLine("Guess my favorite number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 90:
                        Console.WriteLine("You guessed 90. Try again.");
                        Console.WriteLine("Guess my favorite number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 35:
                        Console.WriteLine("You guessed 35. Try again.");
                        Console.WriteLine("Guess my favorite number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("You guessed 8. That is my favorite number!!");
                        guess = true; // the bool guess is true
                        break;

                    default:
                        Console.WriteLine("Nope. Try again.");
                        Console.WriteLine("Guess my favorite number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }


            }
            while (!guess); // while loop is false, will do the above
            Console.Read();
            
            }
        }
    }

