using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_8
{
    public class RationCreator
    {
        public static void RationCreate(Shop shop, Person person) 
        {

            foreach (var day in new List<DayOfWeek>{
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday})
            {
                while (person.CalculateCaloriesByDay(day) <= person.MaxNumberOfCalories)
                {
                    person.AddProduct(day, shop.GetProduct());
                }
            }
        }
    }
}
