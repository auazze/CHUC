using System;

namespace DONE_3_ЛПЗ
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
                    Console.WriteLine("Input 3 numbers 1 by 1");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 < 0)
                    {
                        Console.WriteLine($"Your number {num1} is negative");
                    }
                    else if(num1 > 0)
                    {
                        Console.WriteLine($"Your number {num1} is positive");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid number");
                    }
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    if (num2 < 0)
                    {
                        Console.WriteLine($"Your number {num2} is negative");
                    }
                    else if (num2 > 0)
                    {
                        Console.WriteLine($"Your number {num2} is positive");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid number");
                    }
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    if (num3 < 0)
                    {
                        Console.WriteLine($"Your number {num3} is negative");
                    }
                    else if (num3 > 0)
                    {
                        Console.WriteLine($"Your number {num3} is positive");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid number");
                    }
                    break;
                case "2":
                    Console.WriteLine("\n ЗАДАНИЕ № 2");
                    Console.WriteLine("Input 3 numbers 1 by 1");
                    int num1st = Convert.ToInt32(Console.ReadLine());
                    int num2nd = Convert.ToInt32(Console.ReadLine());
                    int num3rd = Convert.ToInt32(Console.ReadLine());
                    if (num2nd <= num3rd && num2nd <= num1st)
                    {
                        Console.WriteLine($"The max sum of 2 is {num1st} + {num3rd} = {num1st + num3rd}");
                    }
                    else if (num1st <= num3rd && num1st <= num2nd)
                    {
                        Console.WriteLine($"The max sum of 2 is {num2nd} + {num3rd} = {num2nd + num3rd}");
                    }
                    else
                    {
                        Console.WriteLine($"The max sum of 2 is {num2nd} + {num1st} = {num2nd + num1st}");
                    }
                    break;
                case "3":
                    Console.WriteLine("\n ЗАДАНИЕ № 3");
                    Console.WriteLine("Input the number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == 0)
                    {
                        Console.WriteLine($"Your number {num} is 0");
                    }
                    if (num < 0)
                    {
                        Console.WriteLine($"Your number {num} is negative");
                    }
                    if (num > 0)
                    {
                        Console.WriteLine($"Your number {num} is positive");
                    }
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"And an even (чётное)");
                    }
                    if (num % 2 != 0)
                    {
                        Console.WriteLine($"And an odd (нечётное)");
                    }
                    break;
                default:
                    Console.WriteLine("\n НЕИЗВЕСТНАЯ КОМАНДА");
                    break;
                case "4":
                    Console.WriteLine("\n ЗАДАНИЕ № 4");
                    Console.WriteLine("Input 3 numbers 1 by 1");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (a >= b && b >= c)
                    {
                        Console.WriteLine($"Doubled values: {a * 2}, {b * 2} and {c * 2}");
                    }
                    else
                    {
                        decimal adec = Convert.ToDecimal(a);
                        decimal bdec = Convert.ToDecimal(b);
                        decimal cdec = Convert.ToDecimal(c);
                        Console.WriteLine($"Absolute: {Math.Abs(adec)}, {Math.Abs(bdec)} and {Math.Abs(cdec)}");
                    }
                    break;
                case "5":
                    Console.WriteLine("\n ЗАДАНИЕ № 5");
                    Console.WriteLine("Input X and Y coordinates");
                    double x = Convert.ToDouble(Console.ReadLine());
                    double y = Convert.ToDouble(Console.ReadLine());
                    double xminus = x - 1;
                    double xd = Math.Pow(x, 2);
                    double yd = Math.Pow(y, 2);
                    double xdyd = xd + yd;
                    if (y <= 1 && y <= xminus && xdyd <= 1)
                    {
                        Console.WriteLine("Yep!");
                    }
                    else
                    {
                        Console.WriteLine("Nah...");
                    }
                    break;
            }

            WehereToGo();
        }
        public static void WehereToGo()
        {
            Console.Write("\n Выберите задачу\n" +
                "1.Задача \n" +
                "2.Задача \n" +
                "3.Задача \n" +
                "4.Задача \n" +
                "5.Задача \n" + "ВЫБОР:"
                );
            string command = (Console.ReadLine());
            GO(command);
        }
    }
}