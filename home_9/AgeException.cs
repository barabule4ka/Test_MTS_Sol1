using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_9
{
    internal class AgeException : ArgumentException
    {
        public int Age { get; }
        public AgeException(string message, int age) : base(message)
        {
            Age = age;
        }
    }
}
