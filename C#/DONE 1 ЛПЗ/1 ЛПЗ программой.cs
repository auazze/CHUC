using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Задача
            Console.WriteLine($"Введите сумму заказа в ресторане: ");
            double sum = Convert.ToInt32(Console.ReadLine());
            double chai = sum * 0.2;
            Console.WriteLine($"Сумма чаевых официанту: {chai}");
            double nalog = sum * 0.13;
            Console.WriteLine($"Сумма налога: {nalog}");
            double result = sum + chai + nalog;
            Console.WriteLine($"Остаток: {result}");


            // 3 Задача
            Console.WriteLine($"Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            int plus = a + b;
            Console.WriteLine($"сумма a и b: {plus}");
            int minus = a - b;
            Console.WriteLine($"разница между a и b: {minus}");
            int umnojenie = a * b;
            Console.WriteLine($"произведение a и b: {umnojenie}");
            int delim1 = a / b;
            Console.WriteLine($"частное от деления a на b: {delim1}");
            int delim2 = a % b;
            Console.WriteLine($"остаток от деления a на b: {delim2}");
            double up = Math.Pow(a, b);
            Console.WriteLine($"результат возведения числа a в степень b: {up}");


            //4 Задание
            Console.WriteLine($"Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"Введённое Вами число - чётное");
            }
            else
            {
                Console.WriteLine($"Введённое Вами число - не чётное");
            }


            //6 Задача
            Console.WriteLine($"Введите возраст собаки");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1 || a == 2)
            {
                Console.WriteLine($"Возраст собаки по-человечески - {a * 10.5}");
            }
            else if (a >= 3)
            {
                Console.WriteLine($"Возраст собаки по-человечески - {(a - 2) * 4 + 21}");
            }
            else
            {
                Console.WriteLine($"Не верно");
            }



        }
    }
}
