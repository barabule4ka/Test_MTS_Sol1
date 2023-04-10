using System;
using System.Data.SqlTypes;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
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

        /// <summary>
        /// 4. Дана строка: Good day
        /// Необходимо с помощью метода substring удалить слово "Good". 
        /// После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        /// Заменить последний "!" на "?" и вывести результат на консоль.
        /// </summary>
        public static void Task4()
        {
            string strBasic = "Good day";
            string strNewString = "The best ";

            Console.WriteLine(strBasic.Substring(5, 3).Insert(0, strNewString).Insert(12, "!!!!!!!!!").Substring(0, 20) + "?");
        }

        /// <summary>
        /// 5. Введите с консоли строку, которая будет содержать буквы и цифры. 
        /// Удалите из исходной строки все цифры и выведите их на экран.(Использовать метод Char.IsDigit(), 
        /// его не разбирали на уроке, посмотрите, пожалуйста, документацию этого метода самостоятельно)
        /// </summary>
        public static void Task5()
        {
            string strBasic = Console.ReadLine();
            char[] array = strBasic.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsDigit(array[i])) {
                    Console.Write(array[i]);
                }
            }

            Console.WriteLine();
        }

        /// <summary>
        /// 6. Задайте 2 предложения из консоли. 
        /// Для каждого слова первого предложения определите количество его вхождений во второе предложение.
        /// </summary>
        public static void Task6()
        {
            string strBasic1 = Console.ReadLine();
            string strBasic2 = Console.ReadLine();

            string[] arrayBasic1 = strBasic1.Split(" ");
            string[] arrayBasic2 = strBasic2.Split(" ");

            for (int i = 0; i < arrayBasic2.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arrayBasic1.Length; j++)
                {
                    if (arrayBasic1[j] == arrayBasic2[i])
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Number of repetitions for a word \"{arrayBasic2[i]}\" - {count}") ;
            }
        }
    }
}