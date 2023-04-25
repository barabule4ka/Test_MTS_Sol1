using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_8
{
    public class Product
    {
        public string Name;
        public int NumberOfCalories;

        public Product(string name, int numberOfCalories) 
        {
            Name = name;
            NumberOfCalories = numberOfCalories;
        }

        public void ShowInfo() {
            Console.WriteLine($"Product Name: {Name} Calories: {NumberOfCalories}");
        }

    }
}
