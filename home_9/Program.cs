using System;

namespace home_9 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        /// <summary>
        /// Создайте коллекцию состояющую из объектов Person (поля Name, Age, Salary)
        /// Выведите всех Person, чье имя начинается на A
        /// Выведите всех Person, у кого зп больше 1000 и возраст меньше 30. 
        /// Выведите первого человека старше 50 
        /// Добавьте свои классы исключений - SalaryException, AgeException и добавьте в поля Age и Salary проверку, 
        /// если Age меньше 18 - сгенерируйте исключение, если salary меньше 100 - сгенерируйте исключение
        /// Обработайте исключения
        /// </summary>

        static void Main(string[] args)
        {   // Выведите всех Person, чье имя начинается на A
            List<Person> persons = PersonCreator.CreatePersonList();

            Console.WriteLine("People with names which started from A");
                       
            var peopleWithNamesA = from person in persons
                                   where person.Name.StartsWith("A")
                                   select person;
            foreach (var person in peopleWithNamesA)
            {
                Console.WriteLine(person.Name);
            }

            // Выведите всех Person, у кого зп больше 1000 и возраст меньше 30.
            Console.WriteLine("People with salary more than 1000 and age below 30");
                        
            var peopleWithSalaryAndAge = from person in persons
                                         where (person.Salary > 1000 && person.Age <30)                                         
                                         select person;
            foreach (var person in peopleWithSalaryAndAge)
            {
                Console.WriteLine($"{person.Name}, {person.Salary}, {person.Age}");
            }

            // Выведите первого человека старше 50 
            Console.WriteLine("First person older 50");

            var personAgeMoreThanFifty = persons.First(person => person.Age > 50);

            Console.WriteLine($"{personAgeMoreThanFifty.Name}, {personAgeMoreThanFifty.Salary}, {personAgeMoreThanFifty.Age}");

            //Обрабатываем исключения, например:
            Console.WriteLine("Exceptions:");
            Console.WriteLine("Silvia, age: 19, salary: 99");

            try
            {
                 new Person("Silvia", 19, 99);
            }
            catch (AgeException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (SalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Lusia, age: 10, salary: 125");

            try
            {
                new Person("Lusia", 10, 1000);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}