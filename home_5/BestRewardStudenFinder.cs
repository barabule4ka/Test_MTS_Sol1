using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    internal class BestRewardStudenFinder
    {
        public static Student FindBestRewardStudent(Group[] groups) {

            int maxReward = 0;
            Student bestStudent = groups[0].Students[0];

            foreach (var group in groups)
            {
                foreach (var student in group.Students)
                {
                    if (student.Reward > maxReward) {
                        maxReward = student.Reward;
                        bestStudent = student;
                    }
                }
            }

            return bestStudent;
        }
    }
}
