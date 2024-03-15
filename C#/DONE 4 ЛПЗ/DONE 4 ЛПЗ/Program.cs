using System;

namespace DONE_4_ЛПЗ
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
                    Console.WriteLine("\n ЗАДАНИЕ № 1");
                    Console.WriteLine("Введите номер операции: 1 - Сложение, 2 - Вычитание, 3 - Умножение, 4 - Деление");
                    int doing = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите 1 число");
                    int A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите 2 число");
                    int B = Convert.ToInt32(Console.ReadLine());
                    if (doing == 1)
                    {
                        Console.WriteLine($"A + B = {A + B}");
                    }
                    else if (doing == 2)
                    {
                        Console.WriteLine($"A - B = {A - B}");
                    }
                    else if (doing == 3)
                    {
                        Console.WriteLine($"A * B = {A * B}");
                    }
                    else if (doing == 4)
                    {
                        Console.WriteLine($"A / B = {A / B}");
                    }
                    break;
                case "2":
                    Console.WriteLine("\n ЗАДАНИЕ № 2");
                    Console.WriteLine("Введите достоинство карты (от 6 до 14)");
                    int dost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите масть карты (от 1 до 4)");
                    int mast = Convert.ToInt32(Console.ReadLine());
                    if (dost == 6)
                    {
                        Console.Write($"Шестёрка");
                    }
                    if (dost == 7)
                    {
                        Console.Write($"Семёрка");
                    }
                    if (dost == 8)
                    {
                        Console.Write($"Восьмёрка");
                    }
                    if (dost == 9)
                    {
                        Console.Write($"Девятка");
                    }
                    if (dost == 10)
                    {
                        Console.Write($"Десятка");
                    }
                    if (dost == 11)
                    {
                        Console.Write($"Валет");
                    }
                    if (dost == 12)
                    {
                        Console.Write($"Дама");
                    }
                    if (dost == 13)
                    {
                        Console.Write($"Король");
                    }
                    if (dost == 14)
                    {
                        Console.Write($"Туз");
                    }
                    if (mast == 1)
                    {
                        Console.Write($" Пики");
                    }
                    if (mast == 2)
                    {
                        Console.Write($" Треф");
                    }
                    if (mast == 3)
                    {
                        Console.Write($" Бубен");
                    }
                    if (mast == 4)
                    {
                        Console.Write($" Черви");
                    }
                    break;
                case "3":
                    Console.WriteLine("\n ЗАДАНИЕ № 3");
                    break;
                default:
                    Console.WriteLine("\n НЕИЗВЕСТНАЯ КОМАНДА");
                    break;
            }

            WehereToGo();
        }
        public static void WehereToGo()
        {
            Console.Write("\n Выберите задачу\n" +
                "1.Задача \n" +
                "2.Задача \n" +
                "3.Задача \n" + "ВЫБОР:"
                );
            string command = (Console.ReadLine());
            GO(command);
        }
    }
}
