using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters__Generics__Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp = new Employee<string>();
            emp.Things = new List<string>();

            emp.Things.Add("Lilian");
            emp.Things.Add("Karen");
            emp.Things.Add("Wendy");

            foreach (string employee in emp.Things)
            {
                Console.WriteLine(employee);
            }

            Employee<int> emp1 = new Employee<int>();
            emp1.Things = new List<int>();

            emp1.Things.Add(1);
            emp1.Things.Add(2);
            emp1.Things.Add(3);

            // create a loop that prints all of Things to the Console
            foreach (int employee in emp1.Things)
            {
                Console.WriteLine(employee);
            }

            //foreach (string emplist in emp.Things)
            //{
            //    Console.WriteLine(emplist);
            //}

            Console.WriteLine();
            Console.WriteLine("Press any key to shut down ....");
            Console.ReadLine();
        }
    }
}
