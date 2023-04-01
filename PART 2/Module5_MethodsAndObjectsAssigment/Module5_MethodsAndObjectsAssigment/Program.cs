using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_MethodsAndObjectsAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside of the Main method, instantiate and initialize an Employee subject with
            //the first name "Sample" and the last name "Student"
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
