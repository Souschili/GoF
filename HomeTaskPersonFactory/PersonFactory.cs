using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPersonFactory
{
    public class PersonFactory
    { 
        public Person CreatePerson(string name)
        {
            return new Person {Name=name};
        }
    }
}
