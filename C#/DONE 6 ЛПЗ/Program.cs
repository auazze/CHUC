using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE_6_ЛПЗ
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
                    Console.WriteLine("Введите первое число: ");
                    double number1;
                    while (!double.TryParse(Console.ReadLine(), out number1))
                    {
                        Console.WriteLine("Это не число. Попробуйте снова: ");
                    }

                    Console.WriteLine("Введите второе число (делитель): ");
                    double number2;
                    while (!double.TryParse(Console.ReadLine(), out number2))
                    {
                        Console.WriteLine("Это не число. Попробуйте снова: ");
                    }

                    if (number2 == 0)
                    {
                        Console.WriteLine("Деление на ноль!");
                    }
                    else
                    {
                        double result = number1 / number2;
                        Console.WriteLine($"{number1} / {number2} = {result}");
                    }
                    break;
                case "2":
                    Console.WriteLine("\nЗАДАНИЕ № 2");
                    Console.WriteLine("Введите первое число: ");
                    double number11;
                    while (!double.TryParse(Console.ReadLine(), out number11))
                    {
                        Console.WriteLine("Это не число. Попробуйте снова: ");
                    }

                    Console.WriteLine("Введите второе число: ");
                    double number22;
                    while (!double.TryParse(Console.ReadLine(), out number22))
                    {
                        Console.WriteLine("Это не число. Попробуйте снова: ");
                    }

                    Console.WriteLine("Введите операцию (+, -, *, /): ");
                    string operation = Console.ReadLine();

                    double result1;
                    switch (operation)
                    {
                        case "+":
                            result1 = number11 + number22;
                            Console.WriteLine($"{number11} + {number22} = {result1}");
                            break;
                        case "-":
                            result1 = number11 - number22;
                            Console.WriteLine($"{number11} - {number22} = {result1}");
                            break;
                        case "*":
                            result1 = number11 * number22;
                            Console.WriteLine($"{number11} * {number22} = {result1}");
                            break;
                        case "/":
                            if (number22 == 0)
                            {
                                Console.WriteLine("Деление на ноль!");
                            }
                            else
                            {
                                result1 = number11 / number22;
                                Console.WriteLine($"{number11} / {number22} = {result1}");
                            }
                            break;
                        default:
                            Console.WriteLine("Некорректная операция, введите одну из следующих операций: +, -, *, /");
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("\nЗАДАНИЕ № 3");
                    while (true)
                    {
                        double result2 = 1;
                        Console.WriteLine("Введите число или 'result' для вывода результата, 'exit' или 'quit' для выхода:");

                        while (true)
                        {
                            string input = Console.ReadLine().Trim().ToLower();
                            if (input == "result")
                            {
                                Console.WriteLine($"Итоговый результат: {result2}");
                                break;
                            }
                            else if (input == "exit" || input == "quit")
                            {
                                Console.WriteLine("Программа завершена.");
                                break;
                            }
                            else
                            {
                                double number;
                                if (double.TryParse(input, out number))
                                {
                                    result2 *= number;
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный ввод, пожалуйста, введите число, 'result', 'exit' или 'quit'.");
                                }
                            }
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("\nЗАДАНИЕ № 4");
                    string myVariable = "Привет, мир!";
                    Console.WriteLine(myVariable);

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(myVariable);
                                                
                        string innerVariable = "Внутренняя переменная: " + i.ToString();

                        Console.WriteLine(innerVariable);
                    }

                    // Console.WriteLine(innerVariable); // Эта строка вызовет ошибку компиляции.
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
                "4 Задача \n" + "\nВЫБОР: "
                );
            string command = (Console.ReadLine());
            GO(command);
        }
    }
}

