using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    internal class GroupPrinter
    {
        public static void Print(Group[] groups) {
            foreach (Group group in groups) {
                group.ShowInfo();            
            }
        }
    }
}
