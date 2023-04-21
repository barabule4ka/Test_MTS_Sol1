using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace home_6
{
    public class Doctor:Person
    {
        public Specialization Specialization { get; set; }

        public Doctor(string name, Specialization specialization):base (name) 
        {
            Specialization = specialization;
        }

        public void Treat(Patient patient)
        { 
            Console.WriteLine($"Doctor {Name} is {Specialization} and threats {patient.Ilness}");
        }
    }
}