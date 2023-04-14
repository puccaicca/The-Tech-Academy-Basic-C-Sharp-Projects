using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    interface IQuittable
    {
        void Quit(IQuittable Quitter);
    }
}
