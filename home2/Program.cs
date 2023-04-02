using System;
using System.ComponentModel.Design;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Task1();
            Task2();
            Task3();
            Task4();
        }


      /*  public static void Task1()
        {
            *Напишите программу - консольный калькулятор.
            *Создайте две переменные с именами operand1 и operand2.
            *Задайте переменным некоторые произвольные значения.
            *Предложите пользователю ввести знак арифметической операции.
            *Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
            *Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
            *Выведите на экран результат выполнения арифметической операции.
            **В случае использования операции деления, организуйте проверку попытки деления на ноль.
            *И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.*

        }*/


        public static void Task2()
        {
            /*Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 
            *в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100].
            *Если да, то укажите, в какой именно промежуток.
            *Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, 
            *то выводится соответствующее сообщение.
            НЕ ДОБАВЛЯЮ ПРОВЕРКУ НЕ НА ЧИСЛА
             */

            Console.WriteLine("Please, enter any number from 0 to 100");
            
            double number = Convert.ToDouble(Console.ReadLine());

            if ((number >= 0) && (number <= 14))
            {
                Console.WriteLine($"Number {number} is in interval [0-14]");
            }
            else if ((number >= 15) && (number <= 35))
            { 
                Console.WriteLine($"Number {number} is in interval [15-35]");
            }
            else if ((number >= 36) && (number < 50))
            {
                Console.WriteLine($"Number {number} is in interval [36-50]");
            }
            else if ((number > 50) && (number <= 100))
            {
                Console.WriteLine($"Number {number} is in interval [50-100]");
            }
            else if (number == 50)
            {
                Console.WriteLine($"Number {number} is in intervals [36-50] and [50-100]");
            }
            else
            {
                Console.WriteLine("No intervals found");
            }

        }


       public static void Task3()
        {
            /*Напишите программу русско-английский переводчик.
            *Программа знает 10 слов о погоде.
            *Требуется, чтобы пользователь вводил слово на русском языке, 
            *а программа давала ему перевод этого слова на английском языке.
            *Если пользователь ввел слово, для которого отсутствует перевод, 
            *то следует вывести сообщение, что такого слова нет.*/

            Console.WriteLine("Enter a word to translate");

            string weather = Console.ReadLine();

            switch (weather)
            {
                case "солнечно":
                    Console.WriteLine("sunny");
                    break;
                case "тепло":
                    Console.WriteLine("warm");
                    break;
                case "жарко":
                    Console.WriteLine("hot");
                    break;
                case "дождливо":
                    Console.WriteLine("rainy");
                    break;
                case "холодно":
                    Console.WriteLine("cold");
                    break;
                case "морозно":
                    Console.WriteLine("frosty");
                    break;
                case "ветрено":
                    Console.WriteLine("windy");
                    break;
                case "облачно":
                    Console.WriteLine("cloudy");
                    break;
                case "туманно":
                    Console.WriteLine("foggy");
                    break;
                case "гроза":
                    Console.WriteLine("thunderstorm");
                    break;
                default:
                    Console.WriteLine("The word is not in the dictionary");
                    break;
            }
        }


        public static void Task4()
        {
            //Напишите программу, которая будет выполнять проверку чисел на четность.

            Console.WriteLine("Please, enter any integer");

            string numberStr = Console.ReadLine();
            bool numberBool = int.TryParse(numberStr, out int number);

            if (numberBool != true)
            {
                Console.WriteLine("Sorry, only integers required. Try again");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine(number + " is even (chetnoe)");
            }
            else
            {
                Console.WriteLine(number + " is odd (nechetnoe)");
            }




        }


    }
}