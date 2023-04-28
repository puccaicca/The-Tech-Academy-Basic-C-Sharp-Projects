using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();

            example.FirstName = "Lilian";
            example.LastName = "Tan";
            example.ID = 24923;

            Employee example2 = new Employee();
            example2.FirstName = "John";
            example2.LastName = "Wick";
            example2.ID = 39292;

            Console.WriteLine("Employee 1 Information \n \n" + "ID =  " + example.ID + "\n" + "First Name =  "+ example.FirstName + "\n" + "Last Name =  "+ example.LastName + "\n \n");
            Console.WriteLine("Employee 2 Information \n \n" + "ID =  " + example.ID + "\n" + "First Name =  " + example2.FirstName + "\n" + "Last Name =  " + example2.LastName + "\n \n");


           Console.WriteLine("--------- DUPLICATE EMPLOYEE ID ----------- \n");

            if (example == example2)
            {
                Console.WriteLine("Dublicate ID found");
            }
            else
            {
                Console.WriteLine("NO Dublicate ID found");
            }

            Console.ReadLine();
        }
    }
}
