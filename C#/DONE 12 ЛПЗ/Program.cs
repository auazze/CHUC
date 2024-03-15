using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE_12_ЛПЗ
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {            
            // Задача 1 демонстрирует возвращение значения из метода, который вычисляет площадь круга по заданному радиусу.
            Console.WriteLine("Введите радиус круга:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = CalculateArea(radius);
            Console.WriteLine($"Площадь круга: {area}");

            // Задача 2 использует сокращенную запись метода (лямбда-выражение) для формирования полного имени пользователя.
            Console.WriteLine("\nВведите имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string lastName = Console.ReadLine();
            string fullName = GetFullName(firstName, lastName);
            Console.WriteLine($"Полное имя: {fullName}");

            // Задача 3 показывает использование нескольких операторов return для возвращения различных строковых значений в зависимости от классификации числа.
            Console.WriteLine("\nВведите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            string numberClassification = ClassifyNumber(number);
            Console.WriteLine($"Число: {numberClassification}");

            // Задача 4 иллюстрирует выход из метода без возвращения значения с помощью оператора return в определенных ситуациях, например, если число равно нулю, а также дополнительную проверку на четность и знак числа.
            Console.WriteLine("\nВведите число для анализа:");
            int numberForInfo = Convert.ToInt32(Console.ReadLine());
            PrintNumberInfo(numberForInfo);
        }

        // Метод для Задачи 1
        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Метод для Задачи 2
        static string GetFullName(string firstName, string lastName) => $"{firstName} {lastName}";

        // Метод для Задачи 3
        static string ClassifyNumber(int number)
        {
            if (number > 0) return "Положительное";
            if (number < 0) return "Отрицательное";
            return "Ноль";
        }

        // Метод для Задачи 4
        static void PrintNumberInfo(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Ноль");
                return;
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Нечетное");
            }

            if (number > 0)
            {
                Console.WriteLine("Положительное");
            }
            else
            {
                Console.WriteLine("Отрицательное");
            }
        }
    }

}
