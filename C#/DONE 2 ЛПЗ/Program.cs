using System;

namespace ConsoleApp2
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
                    Console.WriteLine("\nЗАДАНИЕ №1");
                    Console.WriteLine("Введите скорость первого автомобиля в км/ч");
                    int V1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите скорость второго автомобиля в км/ч");
                    int V2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите расстояние между автомобилями в км");
                    int S = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите сколько прошло времени в часах");
                    int T = Convert.ToInt32(Console.ReadLine());
                    int result = Math.Abs(S - (V1 + V2) * T);
                    Console.WriteLine($"Расстояние между автомобилями стало {result} км за {T} часа(ов)");
                    break;
                case "2":
                    Console.WriteLine("\nЗАДАНИЕ №2");
                    Console.WriteLine("Введите координаты x1");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координаты y1");
                    double y1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координаты x2");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координаты y2");
                    double y2 = Convert.ToDouble(Console.ReadLine());
                    double dot = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                    Console.WriteLine($"Расстояние между точками {dot}");
                    break;
                case "3":
                    Console.WriteLine("\nЗАДАНИЕ №3");
                    Console.WriteLine("Введите число A");
                    int A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число B");
                    int B = Convert.ToInt32(Console.ReadLine());                   
                    if (A > B)
                    {
                        int remain = A % B;
                        Console.WriteLine($"Остаток отрезка A - {remain}");
                    }
                    else
                    {
                        Console.WriteLine("Число B больше A. Укажите значение отрезка A больше, чем значение отрезка B");
                    }
                    break;
                case "4":
                    Console.WriteLine("\nЗАДАНИЕ №4");
                    Console.WriteLine("Введите трехзначное число");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int hundreds = number / 100;
                    int tens = (number / 10) % 10;
                    int units = number % 10;
                    int swappedNumber = tens * 100 + hundreds * 10 + units;
                    Console.WriteLine($"Число после перестановки\n{swappedNumber}");
                    break;
                case "5":
                    Console.WriteLine("\nЗАДАНИЕ №5");
                    Console.Write("Введите номер дня в году (1-365): ");
                    int K = int.Parse(Console.ReadLine());
                    string[] daysOfWeek = new string[] { "воскресенье", "понедельник", "вторник", "среда", "четверг", "пятница", "суббота" };
                    int firstDayOfYear = 4;
                    int dayOfWeekIndex = (K - 1 + firstDayOfYear) % 7;
                    Console.WriteLine($"Номер дня недели для {K}-го дня года: {dayOfWeekIndex} ({daysOfWeek[dayOfWeekIndex]})");
                    break;
                default:
                    Console.WriteLine("\nНЕИЗВЕСТНАЯ КОМАНДА");
                    break;
            }

            WehereToGo();
        }
        public static void WehereToGo()
        {
            Console.Write("\nВыберите задачу:\n" +
                "1 Задача \n" +
                "2 Задача \n" +
                "3 Задача \n" +
                "4 Задача \n" +
                "5 Задача \n" + "ВЫБОР: "
                );
            string command = (Console.ReadLine());
            GO(command);
        }
    }
}

