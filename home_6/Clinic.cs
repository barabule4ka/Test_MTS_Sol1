using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace home_6
{
    internal class Clinic
    {
        public string Name { get; set; }
        public Doctor[] Doctors { get; set; }

        public Clinic(string name) 
        {
            Name = name;
        }

        public void SendPatientToDoctor(Patient patient)
        {
            Doctor doctor = null;
            switch (patient.Ilness)
            {
                case (IlnessType.Eyes):
                    doctor = FindDoctor(Specialization.Ophthalmologist);
                    break;
                case(IlnessType.Teeth):
                    doctor = FindDoctor(Specialization.Dentist);
                    break;
                case (IlnessType.Other):
                    doctor = FindDoctor(Specialization.Therapist);
                    break;
            }

            if (doctor != null)
            {
                doctor.Treat(patient);
                Console.WriteLine($"{patient.Name} with problem {patient.Ilness} was send to doctor {doctor.Name}, {doctor.Specialization}");
            } else {
                Console.WriteLine($"Doctor for patient {patient.Name} not found");
            }
        }

        private Doctor FindDoctor(Specialization specialization) {
            foreach (Doctor doctor in Doctors) {
                if (doctor.Specialization == specialization) {
                    return doctor;
                }
            }
            
            throw new NotSupportedException("doctor with this specialization not exists");
        }
    }
}
