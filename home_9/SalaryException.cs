using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_9
{
    internal class SalaryException : Exception
    {
        public int Salary { get; }
        public SalaryException(string message, int salary) : base(message)
        {
            Salary = salary;
        }
    }
}
