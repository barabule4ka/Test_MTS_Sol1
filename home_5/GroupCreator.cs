using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    internal class GroupCreator
    {
        public static Group[] CreateGroup() {
            Group[] groups = new Group[3];

            for (int i = 0; i < 3; i++) {
                groups[i] = new Group(i, "Group" + (i+1), StudentCreator.CreateStudent("Group"+ (i + 1)));
            }

            return groups;
        }
    }
}
