﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛПЗ1
{
    class Program
    {
        static void Main(string[] args)
        {
            WehereToGo();
        }

        public static void GO(string command)
        {

            switch (command)
            {
                case "1":
                    Console.WriteLine("\nЗАДАНИЕ № 1");
                    // 1 Задача
                    Console.WriteLine($"Введите сумму заказа в ресторане: ");
                    double sum = Convert.ToInt32(Console.ReadLine());
                    double chai = sum * 0.2;
                    Console.WriteLine($"Сумма чаевых официанту: {chai}");
                    double nalog = sum * 0.13;
                    Console.WriteLine($"Сумма налога: {nalog}");
                    double result = sum + chai + nalog;
                    Console.WriteLine($"Остаток: {result}");
                    break;
                case "2":
                    Console.WriteLine("\nЗАДАНИЕ № 2");
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
                    break;
                case "3":
                    Console.WriteLine("\nЗАДАНИЕ № 3");
                    //4 Задание
                    Console.WriteLine($"Введите число");
                    int A = Convert.ToInt32(Console.ReadLine());
                    if (A % 2 == 0)
                    {
                        Console.WriteLine($"Введённое Вами число - чётное");
                    }
                    else
                    {
                        Console.WriteLine($"Введённое Вами число - не чётное");
                    }
                    break;
                case "4":
                    Console.WriteLine("\nЗАДАНИЕ № 4");
                    //6 Задача
                    Console.WriteLine($"Введите возраст собаки");
                    int aa = Convert.ToInt32(Console.ReadLine());
                    if (aa == 1 || aa == 2)
                    {
                        Console.WriteLine($"Возраст собаки по-человечески - {aa * 10.5}");
                    }
                    else if (aa >= 3)
                    {
                        Console.WriteLine($"Возраст собаки по-человечески - {(aa - 2) * 4 + 21}");
                    }
                    else
                    {
                        Console.WriteLine($"Не верно");
                    }
                    break;
                case "5":
                    Console.WriteLine("\nЗАДАНИЕ № 5");

                    break;
                default:
                    Console.WriteLine("\nНЕИЗВЕСТНАЯ КОМАНДА");
                    break;
            }

            WehereToGo();
        }
        public static void WehereToGo()
        {
            Console.Write("\nВыберите задачу\n" +
                "1 Задача \n" +
                "2 Задача \n" +
                "3 Задача \n" +
                "4 Задача \n" + "ВЫБОР:"
                );
            string command = (Console.ReadLine());
            GO(command);
        }
    }
}

