using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface IStrategy
    {
        List<Person> Algorithm(Person person, string path);
    }
}
