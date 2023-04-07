using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task0();
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
            Console.WriteLine(Environment.NewLine+"Please enter any number from 0 to 9");

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
    }
}