using System;
using System.Net;

namespace home_7 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        /// <summary>
        /// Реализовать систему работы ресторана Макдональдс. В системе должны быть следующие участники
        /// Cleaner - уборщик, умеет убираться.
        /// Cook - повар, умеет готовить и убираться
        /// Менеджер - Умеет решать конфликты, готовить, управлять персоналом
        /// Создать метод, который будет имитировать работу ресторана c выводом информации на консоль.
        /// Ex(Manager is managing people
        /// Cook is cooking
        /// Cleaner is cleaning
        /// Manager is solving conflicts
        /// Manager is cooking.
        /// Cook is cleaning.)
        /// Переопределить метод ToString() в каждом классе сотрудников ресторана.
        /// </summary>
        
        static void Main(string[] args)
        {
            Manager manager = new Manager("Vasya");
            Cook cook = new Cook("Petya");
            Cleaner cleaner = new Cleaner("Masha");

            manager.ToManage();
            cook.ToCook();
            cleaner.ToClean();
            manager.ToSolve();
            manager.ToCook();
            cook.ToClean();
        }
    }
}