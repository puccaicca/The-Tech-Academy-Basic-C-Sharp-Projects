using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator == (Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)

                return true;
            else
                return false;
        }

        public static bool operator != (Employee employee, Employee employee2)
        {
            return employee.ID != employee2.ID;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false; //optional. depends on logic
            return this.ID.Equals(((Employee)obj).ID);
        }
    }
}
