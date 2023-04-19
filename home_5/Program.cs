using System;
using System.Text.RegularExpressions;

namespace home_5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {

            Group[] groups = InitGtroupAndStudent();

            FindBestDiscplineMark(groups);
            FindAverageStudentMarkByGroup(groups);
            FindBestStudentAndAddReward(groups);


            Console.WriteLine("Student with max reward: ");
            BestRewardStudenFinder.FindBestRewardStudent(groups).ShowInfo();
        }


        public static Group[] InitGtroupAndStudent() {
            Group[] groups = GroupCreator.CreateGroup();
            
            GroupPrinter.Print(groups);

            return groups;
        }

        public static void FindBestDiscplineMark(Group[] groups) {
            Random rnd = new Random();
            Console.WriteLine("Best Math");
            foreach (Student student in BestMarkCalculator.CalculateMath(groups))
            {
                student.ShowInfo("Math", student.mathMark);
                student.Reward = (int)rnd.NextInt64(1, 100);
            }

            Console.WriteLine("Best Phys");
            foreach (Student student in BestMarkCalculator.CalculatePhys(groups))
            {
                student.ShowInfo("Physical education", student.physicalEducationMark);
                student.Reward = (int)rnd.NextInt64(1, 100);
            }

            Console.WriteLine("Best Bio");
            foreach (Student student in BestMarkCalculator.CalculateBio(groups))
            {
                student.ShowInfo("Biology", student.biologyMark);
                student.Reward = (int)rnd.NextInt64(1, 100);
            }

            GroupPrinter.Print(groups);

        }

        public static void FindAverageStudentMarkByGroup(Group[] groups) {
            foreach (Group group in groups)
            {
                group.ShowAverageForDiscipline("Math", group.FindAverageGroupMath());
                group.ShowAverageForDiscipline("Physical Education", group.FindAverageGroupPhysEducation());
                group.ShowAverageForDiscipline("Biology", group.FindAverageGroupBio());

                Console.WriteLine($"Average mark for Math, PhysicalEducation, Biology of {group.Name}: {group.FindAverageForAllDisciplines()}");
            }
        }

        public static void FindBestStudentAndAddReward(Group[] groups) {
            Random rnd = new Random();
            Console.WriteLine("Best student");
            foreach (Group group in groups)
            {
                Student[] students = group.FindBestStudents();
                foreach (Student student in students)
                {
                    student.Reward = student.Reward + (int)rnd.NextInt64(1, 100);
                    student.ShowInfo();
                }
            }

        }

    }
}
