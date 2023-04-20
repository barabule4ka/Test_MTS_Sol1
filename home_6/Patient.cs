using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_6
{
    public class Patient : Person
    {
        public IlnessType Ilness { get; set; }

        public Patient(string name, IlnessType ilness) : base(name)
        {
            Ilness = ilness;
        }
    }
}
