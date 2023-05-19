using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Threading;
using System.Linq;
using Microsoft.VisualBasic;

namespace home_10 // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        /// <summary>
        /// 1. Cоздать класс мониторинга средней цен на жилье, цена будет генерироваться с помощью класса рандом 
        /// и выдавать случайное значение в определенном диапазоне. Для того чтобы вывод цены был удобен пользователю 
        /// в классе мониторинга создать поле делегат, обьект которого будет создаваться в классе мониторинга. 
        /// Пользователь указывает метод для отображения цены в удобном ему формате путем передачи метода в конструктор класса мониторинга.
        /// пример создания бьекта монитора.
        ///  PriceMonitor monitor = new PriceMonitor(ShowPrice);
        ///  public static void ShowPrice(int price) { //your code  }
        /// </summary>

        static void Main(string[] args)
        {
           
        }

        //Метод возвращает первое слово из последовательности слов, содержащее только одну букву
        public string? OneLetterWord()
        {
            Console.WriteLine("Enter some words or whole sentence");

            char[] separatingChars = { ' ', ',' };
            List<string> word = Console.ReadLine().Split(separatingChars).ToList();

            string oneLetterWord = word.First(word => word.Length == 1);

            Console.WriteLine($"First word with one letter - {oneLetterWord}");

            return oneLetterWord;
        }

        //метод, возвращающий последнее слово, содержащее в себе подстроку «ее». Реализовать, используя только 1 метод LINQ.
        public string? LastSubstringEe()
        {
            Console.WriteLine("Enter some words or whole sentence");

            char[] separatingChars = { ' ', ',' };
            List<string> word = Console.ReadLine().Split(separatingChars).ToList();

            string lastSubstringEe = word.Last(word => word.EndsWith("ее"));

            Console.WriteLine($"Last word contains substring 'ее' (rus) - {lastSubstringEe}");

            return lastSubstringEe;
        }

        //Реализовать метод для возврата последнего слова, соответствующего условию: длина слова не меньше min и не больше max.
        //Если нет слов, соответствующих условию, метод возвращает null.
        public string? BetweenMinAndMaxOrNull()
        {
            Console.WriteLine("Enter some words or whole sentence");

            char[] separatingChars = { ' ', ',' };
            List<string> word = Console.ReadLine().Split(separatingChars).ToList();

            Console.WriteLine("Enter minLength and maxLength");

            int minLength = 2;
            int maxLength = 7;
            string betweenMinAndMaxOrNull = word.LastOrDefault(word => (word.Length >= minLength) && (word.Length <= maxLength));

            Console.WriteLine($"Last word containing > 2 and < 7 letters - {betweenMinAndMaxOrNull}");
            return betweenMinAndMaxOrNull;
        }

        //Напишите метод, который возвращает количество уникальных значений в массиве.
        public int CountUniqueElements()
        {
            string[] elements = { "123", "234", "345", "123", "6", "6" };
           
            var uniqueElements = elements.Distinct().ToList();
            int countUniqueElements = uniqueElements.Count();

            Console.WriteLine($"Number of unique elements in array - {countUniqueElements}");

            return countUniqueElements;
        }

        //Напишите метод, который принимает список и извлекает значения с 5  элемента (включительно)  те значение которые содержат 3
        public List<string> DontKnowHowToNameIt(List<string> strings)
        {
            Console.WriteLine("Enter more than 5 words or numbers ");
            List<string> word = Console.ReadLine().Split().ToList();

            var result = word.Skip(5).Where(word => word.Contains("3"));

            foreach (var words in result)
            {
                Console.WriteLine(words.ToString());
            }

            return word;
        }

        //Метод возвращает длину самого короткого слова
        public int LengthOfShortestWord()
        {
            Console.WriteLine("Enter some words or whole sentence");

            char[] separatingChars = { ' ', ',' };
            List<string> word = Console.ReadLine().Split(separatingChars).ToList();

            var shortestWord = word.OrderBy(word => word.Length).First();

            Console.WriteLine($"The Shortest Word - {shortestWord}");
            Console.WriteLine($"Length Of Shortest Word - {shortestWord.Length}");

            return shortestWord.Length;
        }
    }
}