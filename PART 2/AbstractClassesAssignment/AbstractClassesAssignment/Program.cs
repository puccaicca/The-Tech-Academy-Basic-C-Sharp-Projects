using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main method, instantiate an Employee object
            Employee sam = new Employee() { firstName = "Sample", lastName = " Student" };
            //Call the SayName method on the object
            sam.SayName();
            Console.ReadLine();

            // Use polumorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable NewEmployee = new Employee();

            ((Employee)NewEmployee).firstName = "Karen";
            ((Employee)NewEmployee).lastName = "Wong";

            NewEmployee.Quit(NewEmployee);
            Console.ReadLine();
        }
    }
}
