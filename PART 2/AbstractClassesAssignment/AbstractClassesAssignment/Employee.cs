using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    //Create another class, "Employee" and have it inherit from the Person class
    public class Employee : Person, IQuittable // add iterface class to also be inherited
    {
        
        public int Id { get; set; }
        //Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        // Call the quit method from interface
        public void Quit(IQuittable Quitter)
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " has quit.");
        }

    }
}
