using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters__Generics__Assignment
{
    public class Employee<T>
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<T> Things { get; set; }
    }
}
