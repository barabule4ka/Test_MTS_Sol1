using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_9
{
    internal class Person
    {
        public string Name;
        public int age;
        public int salary;
        public int Salary {
            get => salary;
            set
            {
                if (value < 100)
                {
                    throw new SalaryException($"Salary: {value}. Salary less than 100", value);
                }
                else
                {
                    salary = value;
                }
            }
        }

        public int Age 
        {
            get => age;
            set
            {
                if (value < 18)
                {
                    throw new AgeException($"{value}? You are too young. Your age is below 18", value);
                }
                else 
                {
                age = value;
                }
            }
        }

        public Person(string name, int age, int salary) 
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
