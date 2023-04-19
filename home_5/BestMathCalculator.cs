using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace home_5
{
    internal class BestMarkCalculator
    {
        public static Student[] CalculateMath(Group[] groups) {
            Student[] best = new Student[groups.Length];

            foreach (var group in groups)
            {
                best[group.Id] = group.FindBestStudentMath();
            }

            return best;
        }

        public static Student[] CalculatePhys(Group[] groups)
        {
            Student[] best = new Student[groups.Length];

            foreach (var group in groups)
            {
                best[group.Id] = group.FindBestStudentPhys();
            }

            return best;
        }
        
        public static Student[] CalculateBio(Group[] groups)
        {

            Student[] best = new Student[groups.Length];

            foreach (var group in groups)
            {
                best[group.Id] = group.FindBestStudentBio();
            }

            return best;
        }

        
    }
}
