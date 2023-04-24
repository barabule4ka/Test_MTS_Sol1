using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_7
{
    public class Cleaner : Employee,ICleanable
    {
        public Cleaner(string name) : base(name)
        {

        }

        public void ToClean()
        {
            Console.WriteLine("Cleaner is cleaning");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
