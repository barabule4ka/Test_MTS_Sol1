using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_7
{
    public class Cook: Employee, ICleanable, ICookable
    
    {
        public Cook(string name) : base(name)
        {

        }

        public void ToClean()
        {
            Console.WriteLine("Cook is cleaning");
        }

        public void ToCook()
        {
            Console.WriteLine("Cook is cooking");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
