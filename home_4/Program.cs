using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        /// <summary>
        /// 1. Задать строку содержащую внутри цифры и несколько повторений слова test, 
        /// Заменить в строке все вхождения 'test' на 'testing'.
        /// </summary>
        public static void Task1()
        {
            string myStr = "qwe123 test123 456testqwe 234tes123 test 000 test 11";
            Console.WriteLine("Basic string is: " + myStr);

            myStr = myStr.Replace("test", "testing");
            Console.WriteLine("New string is: " + myStr);
        }

        /// <summary>
        /// Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons)
        /// выполните конкатенацию слов и выведите на экран следующую фразу: Welcome to the TMS lessons. 
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". 
        /// Не забывайте о пробелах после каждого слова
        /// </summary>
        public static void Task2()
        {
            string str1 = "Welcome";
            string str2 = "to";
            string str3 = "the";
            string str4 = "TMS";
            string str5 = "lessons";
            string[] greeting = new string[] { str1, str2, str3, str4, str5};
            string strFinalJoin = string.Join("\" \"", greeting);
            Console.WriteLine($"Solution with join is: \"{ strFinalJoin}\"." );

            string strConcat = string.Concat("\"", str1, "\" \"", str2, "\" \"", str3, "\" \"", str4, "\" \"", str5, "\".");
            Console.WriteLine("Solution with concat is: " + strConcat);
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, 
        /// а также всё, что после них во вторую secondPart.
        /// Результат вывести в консоль.
        /// </summary>
        public static void Task3()
        {
            string strBasic = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string strFormat = strBasic.Replace("abc", " ");
            string[] array = strFormat.Split(new char[] { ' ' });
            string firstPart = array[0];
            string secondPart = array[1];

            Console.WriteLine($"firstPart is: {firstPart} \n\rsecondPart is: {secondPart}");
        }
    }
}