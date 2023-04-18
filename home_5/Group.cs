using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student[] Students { get; set; } = new Student[0];

        public Group(int id, string name, Student[] students) { 
            Id = id;
            Name = name;
            Students = students;
        }

        public void ShowInfo()
        {
            foreach (Student student in Students)
            {
                student.ShowInfo();
            }
        }

        public Student FindBestStudentMath()
        {
            int max = 0;
 
            Student lastStudentWithMaxMark = Students[0];
            foreach (var student in Students)
            {
                if (student.mathMark > max)
                {
                    max = student.mathMark;
                    lastStudentWithMaxMark = student;
                }
            }

            return lastStudentWithMaxMark;
        }

        public Student FindBestStudentPhys()
        {

            int max2 = 0;
            Student lastStudentWithMaxMark = Students[0];
            foreach (var student in Students)
            {
                if (student.physicalEducationMark > max2)
                {
                    max2 = student.physicalEducationMark;
                    lastStudentWithMaxMark = student;
                }
            }

            return lastStudentWithMaxMark;
        }
        
        public Student FindBestStudentBio()
        {

            int max1 = 0;
            Student lastStudentWithMaxMark = Students[0];
            foreach (var student in Students)
            {
                if (student.biologyMark > max1)
                {
                    max1 = student.biologyMark;
                    lastStudentWithMaxMark = student;
                }
            }

            return lastStudentWithMaxMark;
        }

        public double FindAverageGroupMath()
        {
            double sum = 0;
            foreach (var student in Students)
            {
                sum += student.mathMark;
            }
            return sum/Students.Length;
        }

        public double FindAverageGroupPhysEducation()
        {
            double sum = 0;
            foreach (var student in Students)
            {
                sum += student.physicalEducationMark;
            }
            return sum / Students.Length;
        }

        public double FindAverageGroupBio()
        {
            double sum = 0;
            foreach (var student in Students)
            {
                sum += student.biologyMark;
            }
            return sum / Students.Length;
        }

        public void ShowAverageForDiscipline(string discipline, double average)
        {
            Console.WriteLine($"{Name}, average mark for {discipline}: {average}");
        }

        public double FindAverageForAllDisciplines() { 
        
            return (FindAverageGroupMath()+FindAverageGroupPhysEducation()+FindAverageGroupBio())/3;
        
        }

        public Student[] FindBestStudents()
        {
            int maxAverageMark = 0;
            foreach (var student in Students)
            {
                if (student.FindSumMark() > maxAverageMark)
                {
                    maxAverageMark = student.FindSumMark();
                }
            }
            int countStudentsWithBestMark = 0;
            foreach (var student in Students)
            {
                if (student.FindSumMark() >= maxAverageMark)
                {
                    countStudentsWithBestMark++;
                }
            }

            Student[] bestStudents = new Student[countStudentsWithBestMark];
            int index = 0;
            foreach (var student in Students)
            {
                if (student.FindSumMark() >= maxAverageMark)
                {
                    bestStudents[index] = student;
                    index++;
                }
            }
            return bestStudents;
        }
            
    }
}
