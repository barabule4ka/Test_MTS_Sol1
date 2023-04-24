using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace home_8
{
    public class Person
    {
        public string Name { get; set; }
        public int MaxNumberOfCalories { get; set; }
        private Dictionary<DayOfWeek, List<Product>> Ration {get; set;} = new Dictionary<DayOfWeek, List<Product>>()
        {
            [DayOfWeek.Monday] = new List<Product>(),
            [DayOfWeek.Tuesday] = new List<Product>(),
            [DayOfWeek.Wednesday] = new List<Product>(),
            [DayOfWeek.Thursday] = new List<Product>(),
            [DayOfWeek.Friday] = new List<Product>(),
            [DayOfWeek.Saturday] = new List<Product>(),
            [DayOfWeek.Sunday] = new List<Product>()
        };

        public Person(string name, int maxNumberOfCalories) 
        {
            Name = name;
            MaxNumberOfCalories = maxNumberOfCalories;
        }

        /// <summary>
        /// Метод подсчитывает количество калорий в рационе на определенный день, не удаляет продукты
        /// </summary>

        public int CalculateCaloriesByDay(DayOfWeek day) {
            int sum = 0;
            if (Ration.ContainsKey(day)) {
                foreach (Product product in Ration[day])
                {
                    sum += product.NumberOfCalories;
                }
                return sum;
            }

            return sum;
        }

        public void AddProduct(DayOfWeek day, Product product) {
            Ration[day].Add(product);
        }

        /// <summary>
        /// Удаляем продукты из рациона на день, если калораж больше, чем нужно 
        /// </summary>
        public void RemoveProduct()
        {
            foreach (KeyValuePair<DayOfWeek, List<Product>> kvp in Ration)
            {
                while (CalculateCaloriesByDay(kvp.Key) > MaxNumberOfCalories)
                {
                    kvp.Value.RemoveRange(0,1);
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Person - {Name}, calories - {MaxNumberOfCalories}");

            foreach (KeyValuePair<DayOfWeek, List<Product>> kvp in Ration)
            {
                Console.WriteLine("Day of week: " + kvp.Key.ToString());
                foreach (Product product in kvp.Value) {
                    product.ShowInfo();
                }
                Console.WriteLine($"Sum of calories on {kvp.Key} {CalculateCaloriesByDay(kvp.Key)}");
            }    
        }
    }
}
