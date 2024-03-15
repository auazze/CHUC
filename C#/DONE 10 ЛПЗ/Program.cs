using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE_10_ЛПЗ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1: Определение и вызов метода
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            PrintGreeting(name);

            // Задача 2: Метод с возвращаемым значением
            Console.WriteLine("Введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = CalculateSum(num1, num2);
            Console.WriteLine($"Сумма: {sum}");

            // Задача 3: Перегрузка методов
            DisplayInfo("Это строка");
            DisplayInfo(12345);

            // Задача 4: Сокращенная запись методов с использованием лямбда-выражений
            Console.WriteLine("Введите первое число для сравнения:");
            int compareNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для сравнения:");
            int compareNum2 = Convert.ToInt32(Console.ReadLine());
            int max = GetMax(compareNum1, compareNum2);
            Console.WriteLine($"Большее число: {max}");
        }

        // Метод для Задачи 1
        static void PrintGreeting(string userName)
        {
            Console.WriteLine($"Привет, {userName}!");
        }

        // Метод для Задачи 2
        static int CalculateSum(int a, int b)
        {
            return a + b;
        }

        // Методы для Задачи 3: Перегрузка методов
        static void DisplayInfo(string message)
        {
            Console.WriteLine($"Строка: {message}");
        }

        static void DisplayInfo(int number)
        {
            Console.WriteLine($"Число: {number}");
        }

        // Метод для Задачи 4
        static Func<int, int, int> GetMax = (x, y) => x > y ? x : y;
    }
}

