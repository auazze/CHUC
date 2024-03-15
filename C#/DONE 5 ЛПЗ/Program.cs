using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE_5_ЛПЗ
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
                    Console.WriteLine("Введите цену за 1 кг конфет");
                    int candycost = int.Parse(Console.ReadLine());
                    double kgs;
                    for (kgs = 0.1; kgs <= 1; kgs += 0.1)
                    {
                        Console.WriteLine($"Цена за {kgs} кг = {candycost*kgs} бубликов");
                    }
                    break;
                case "2":
                    Console.WriteLine("\nЗАДАНИЕ № 2");
                    Console.WriteLine("Введите число A");
                    int A = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число, в степень которого хотите возвести число A");
                    int Pow = int.Parse(Console.ReadLine());
                    if (Pow <= 0)
                    {
                        Console.WriteLine("Степень не может быть 0 или меньше 0");
                    }
                    else
                    {
                        int result = 1;
                        for (int i = 0; i < Pow; i++)
                        {
                            result *= A;
                        }
                        Console.WriteLine($"{A} в степени {Pow} = {result}");
                    }                    
                    break;
                case "3":
                    Console.WriteLine("\nЗАДАНИЕ № 3");
                    Console.WriteLine("Введите число X, такое что |X| < 1:");
                    string inputX = Console.ReadLine().Replace(',', '.');
                    double X = double.Parse(inputX, CultureInfo.InvariantCulture);
                    Console.WriteLine("Введите целое число N > 0:");
                    int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double sum = 0.0;
                    for (int i = 0; i <= N; i++)
                    {                        
                        double term = Math.Pow(-1, i) * Math.Pow(X, 2 * i + 1) / (2 * i + 1);
                        sum += term;
                    }

                    Console.WriteLine($"Значение выражения: {sum}");
                    break;
                case "4":
                    Console.WriteLine("\nЗАДАНИЕ № 4");
                    Func<int, int> factorial2 = null;
                    factorial2 = (n) => n <= 0 ? 1 : n * factorial2(n - 2);

                    Console.Write("Введите число: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Двойной факториал числа: " + factorial2(n));
                    break;
                case "5":
                    Console.WriteLine("\nЗАДАНИЕ № 5");
                    double startDistance = 10;
                    Console.Write("Введите процент увеличения пробега P: ");
                    double increasePercent = double.Parse(Console.ReadLine());
                    double totalDistance = startDistance;
                    int days = 1;

                    while (totalDistance <= 200)
                    {
                        days++;
                        startDistance += startDistance * (increasePercent / 100);
                        totalDistance += startDistance;
                    }

                    Console.WriteLine($"После {days} дней суммарный пробег лыжника превысит 200 км и составит {totalDistance:F2} км.");
                    break;
                case "6":
                    Console.WriteLine("\nЗАДАНИЕ № 6");
                    Console.Write("Введите число Фибоначчи N (>1): ");
                    int NN = int.Parse(Console.ReadLine());

                    int a = 0;
                    int b = 1;
                    int c = a + b;
                                        
                    while (c < NN)
                    {
                        a = b;
                        b = c;
                        c = a + b;
                    }
                                        
                    if (c == NN)
                    {
                        int nextFibonacci = c + b;
                        Console.WriteLine($"FK-1: {b}, FK+1: {nextFibonacci}");
                    }
                    else
                    {
                        Console.WriteLine("Введенное число не является числом Фибоначчи.");
                    }
                    break;
                case "7":
                    Console.WriteLine("\nЗАДАНИЕ № 7");
                    Console.Write("Введите k: ");
                    double k = double.Parse(Console.ReadLine());

                    double result1 = 2 * k / ((k * k + 1) * (k + 2));
                    Console.WriteLine($"Результат: {result1}");
                    break;
                default:
                    Console.WriteLine("\nНЕИЗВЕСТНАЯ КОМАНДА");
                    break;
            }

            WehereToGo();
        }
        public static void WehereToGo()
        {
            Console.Write("\nВыберите задачу\n\n" +
                "1 Задача \n" +
                "2 Задача \n" +
                "3 Задача \n" +
                "4 Задача \n" +
                "5 Задача \n" +
                "6 Задача \n" +
                "7 Задача \n" + "\nВЫБОР: "
                );
            string command = (Console.ReadLine());
            GO(command);
        }
    }
}

