using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task0();
            Task1();
            Task2();
        }

        public static void Task0()
        {
            /* Создайте массив целых чисел. 
             * Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.  
             * Пусть число для поиска задается с консоли.*/

            //Создаем массив и выводим его.
            Random random = new Random();
            int[] array = new int[15];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.NextInt64(0, 9);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            //Запрашиваем число
            Console.WriteLine(Environment.NewLine + "Please enter any number from 0 to 9");

            string numberStr = Console.ReadLine();
            bool numberBool = double.TryParse(numberStr, out double number);

            switch (numberBool)
            {
                case (true):
                    {
                        bool exists = false;
                        for (int i = 0; i < array.Length; i++)
                        {

                            if (array[i] == number)
                            {
                                exists = true;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine($"Number {number} is in array");
                        }
                        else Console.WriteLine($"Number {number} is not in array");
                        break;
                    }
                case (false):
                    {
                        Console.WriteLine("Only numbers required.");
                        break;
                    }
            }
        }

        public static void Task1()
        {
            /*1.Создайте массив целых чисел.Удалите все вхождения заданного числа из массива.
            *Пусть число задается с консоли.Если такого числа нет -выведите сообщения об этом.
            *В результате должен быть новый массив без указанного числа.*/

            //Создаем массив и выводим его.
            Random random = new Random();
            int[] array = new int[15];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.NextInt64(0,20);
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            //Запрашиваем число
            Console.WriteLine(Environment.NewLine + "Please enter any number");

            string numberStr = Console.ReadLine();
            bool numberBool = double.TryParse(numberStr, out double number);

            if (numberBool)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != number)
                    {
                        counter++;
                    }
                }

                int[] array2 = new int[counter];
                int index = 0;
                int j = 0;

                while (index < array.Length)
                {
                    if (array[index] != number)
                    {
                        array2[j] = array[index];
                        j++;
                    }
                    index++;
                }

                for (int i = 0; i < array2.Length; i++)
                {
                    Console.Write(array2[i] + " ");
                }
            }

            else
            {
                Console.WriteLine("Only numbers required.");

            }
        }


        public static void Task2()
        {
            /* 2. Создайте и заполните массив случайным числами и выведете максимальное, 
             * минимальное и среднее значение.  
             * Для генерации случайного числа используйте метод Random() .  
             * Пусть будет возможность создавать массив произвольного размера.  
             * Пусть размер массива вводится с консоли.*/

            //Создаем массив и выводим его.

            Console.WriteLine(Environment.NewLine + "Please enter array size");

            string numberStr = Console.ReadLine();
            bool numberBool = int.TryParse(numberStr, out int size);

            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.NextInt64(0, 9);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Array.Sort(array);
            if (array.Length > 0)
            {
                Console.WriteLine("\nMinimum number is " + array[0]); //минимальный индекс
                Console.WriteLine("Medium number is " + array[(array.Length-1) / 2]); //средний индекс (не сказано, что среднее арифметическое)
                Console.WriteLine("Maximum number is " + array[array.Length - 1]); //максимальный индекс
            }
        }

    }
}