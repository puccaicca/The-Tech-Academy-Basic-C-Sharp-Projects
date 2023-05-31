using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employees.
            //At least two employees should have the first name "Joe".
            List<Employee> campus = new List<Employee>()
            {
                new Employee() {ID = 1, firstName = "Joe", lastName = "Schmo"},
                new Employee() {ID = 2, firstName = "Joe", lastName = "Thomas"},
                new Employee() {ID = 3, firstName = "Jimbob", lastName = "Coot"},
                new Employee() {ID = 4, firstName = "Lilian", lastName = "Tan"},
                new Employee() {ID = 5, firstName = "Vivien", lastName = "Lamb"},
                new Employee() {ID = 6, firstName = "Nicki", lastName = "Minaj"},
                new Employee() {ID = 7, firstName = "Seokjin", lastName = "Kim"},
                new Employee() {ID = 8, firstName = "Jungkook", lastName = "Jeon"},
                new Employee() {ID = 9, firstName = "Namjoon", lastName = "Kim"},
                new Employee() {ID = 10, firstName = "Jennifer", lastName = "Huh"}
            };
            //Using a foreach loop, create a new list of all employees with the first name "Joe"
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in campus)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            //Do the same thing again, but this time with a lambda expression
            List<Employee> joes2 = campus.Where(x => x.firstName == "Joe").ToList();
            //Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> bigId = campus.Where(x => x.ID > 5).ToList();
            Console.ReadLine();
        }
    }
}
