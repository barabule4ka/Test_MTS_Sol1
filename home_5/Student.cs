using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    /// <summary>
    /// поля Id, Name, Age, Group, MathMark (Оценка по математике от 1 до 10 включительно), 
    /// PhysicalEducationMark (Оценка по физкультуре от 1 до 10), 
    /// BiologyMark (Оценка по биологии от 1 до 10), 
    /// Reward (денежное вознаграждение за хорошую учебу)
    /// </summary>
    internal class Student
    {
        public int id;
        public string name;
        public int age;
        public string group;
        public int mathMark;
        public int physicalEducationMark;
        public int biologyMark;
        int reward;
        public int Reward { set {
                if (value < 1) {
                    Console.WriteLine("Error: reward expected more 1");
                } else { 
                    reward = value;
                }
            } get {
                return reward;
            }
        }


        public Student(int id, string name, int age, string group, int mathMark, int physicalEducationMark, int biologyMark)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.group = group;
            this.mathMark = mathMark;
            this.physicalEducationMark = physicalEducationMark;
            this.biologyMark = biologyMark;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"{id}, {name}, {age}, {group}, {mathMark}, {physicalEducationMark}, {biologyMark}, {Reward}");
        }
        public void ShowInfo(string discipline, int mark) {

            Console.WriteLine($"{name}, {group}, best {discipline} mark is: {mark}");
        }

        public int FindSumMark()
        {
            return (this.mathMark+this.physicalEducationMark+this.biologyMark);
        }
    }

}
