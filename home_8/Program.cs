using System;
using System.Collections.Generic;

namespace home_8 // Note: actual namespace depends on the project name.
{
    /// <summary>
    /// Составьте рацион питания для человека на неделю (Person - Содержит поля Name, MaxNumberOfCalories
    /// (Макс Количество-калорий потребляемых за день)).
    /// Cам рацион представляет пару ключ(День недели(Enum) - значение (список продуктов) - List.
    /// Продукт содержит поля: название продукта, Количество калорий (1 class Product)
    /// Составьте рацион произвольным образом(пример: создайте класс RationCreator и добавьте в него метод по созданию рациона) 
    /// на каждый день и назначьте его Person.
    /// Добавьте метод в классе Person, который проверит рацион на каждый день 
    /// и если в какой-то день общее количество калорий превышает максимальное, 
    /// будет удалять продукты из списка, пока сумма их калорий будет меньше либо равна
    /// максимальному количеству калорий, потребляемых человеком за день.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter person's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter person's max number of calories per day:");
            string maxNumberOfCaloriesStr = Console.ReadLine();
            bool caloriesBool = int.TryParse(maxNumberOfCaloriesStr, out int maxNumberOfCalories);

            switch (caloriesBool)
            {
                case (false):
                    Console.WriteLine("Only numbers required.");
                    break;

                case (true):
                    Person person = new Person(name, maxNumberOfCalories);
                    Shop shop = new Shop();

                    RationCreator.RationCreate(shop, person);

                    person.ShowInfo();

                    person.RemoveProduct();

                    Console.WriteLine("After remove");
                    person.ShowInfo();
                    break;
            }
        }
    }
}