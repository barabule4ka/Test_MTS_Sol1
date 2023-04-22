using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_7
{
    public class Manager:Employee,ICookable,IManage,ISolveable
    {
        public Manager(string name) : base(name)
        {
           
        }

        public void ToCook()
        {
            Console.WriteLine("Manager is cooking");
        }

        public void ToManage()
        {
            Console.WriteLine("Manager is managing people");
        }

        public void ToSolve()
        {
            Console.WriteLine("Manager is solving conflicts");
        }

        public override string ToString() {
            return Name;
        }
    }
}
