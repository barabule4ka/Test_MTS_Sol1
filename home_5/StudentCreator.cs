using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_5
{
    internal class StudentCreator
    {
        public static Student[] CreateStudent(string group) {

            Student[] students = new Student[5];

            string[] names = new string[5] { "Vasya", "Petya", "Masha", "Dasha", "Ivan"};
            Random rnd = new Random();
           
            for (int i = 0; i<5; i++)
            {
                students[i] = new Student(i, names[i], 
                    (int)rnd.NextInt64(18, 23), 
                    group, 
                    (int)rnd.NextInt64(1, 10), 
                    (int)rnd.NextInt64(1, 10), 
                    (int)rnd.NextInt64(1, 10)
                    );
            }
            return students;
        }
    }
}
