using System;
using static System.Net.Mime.MediaTypeNames;

namespace home_6 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        /// <summary>
        /// Создать программу для имитации работы клиники. (Clinic)
        /// Пусть в клинике будет три врача: офтальмолог(ophthalmologist), терапевт(therapist) и стоматолог(dentist).  
        /// Каждый врач имеет метод «лечить» Treat(), но каждый врач лечит по-своему.
        /// Так же предусмотреть класс «Пациент»(Patient) 
        /// и enum «IlnessType» (Eyes, Teeth, Other) - (тип болезни, что человека беспокоит)
        /// Создать объект класса «Пациент». 
        /// Так же создать метод в классе Клиника, который будет отправлять пациента к доктору.Далее доктор должен лечить пациента. 
        /// Если план лечения == Eyes – назначить офтальмолога и выполнить метод лечить. 
        /// Если план лечения == Teeth – назначить стоматолог и выполнить метод лечить.  
        /// Если план лечения == Other – назначить терапевта и выполнить метод лечить.
        /// </summary>
        
        static void Main(string[] args)
        {
            Clinic clinic = new Clinic("My good clinic");
            clinic.Doctors = new Doctor[3] {
               new Doctor("Ivan", Specialization.Ophthalmologist),
               new Doctor("Alex",Specialization.Therapist),
               new Doctor("Gleb", Specialization.Dentist)
            };

            clinic.SendPatientToDoctor(new Patient("Vorobey", IlnessType.Other));
            clinic.SendPatientToDoctor(new Patient("James", IlnessType.Eyes));
            clinic.SendPatientToDoctor(new Patient("Petia", IlnessType.Teeth));
        }
    }
}