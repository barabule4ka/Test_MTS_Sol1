using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_9
{
    internal class PersonCreator
    {
        public static List<Person> CreatePersonList() 
        {
            return new List<Person>()
            {new Person("Avdotia", 18, 100),
             new Person("Vasya", 23, 1456),
             new Person("Alexei", 34, 2489),
             new Person("Ivan", 59, 3980),
             new Person("Anna", 19, 1500),
             new Person("Jenia", 27, 900),
             new Person("Mark", 48, 2987),
             new Person("Ananas", 110, 977),
             new Person("Maks", 51, 101)
            };
        }
    }
}
