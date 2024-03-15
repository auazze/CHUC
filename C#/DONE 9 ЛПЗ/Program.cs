using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE_9_ЛПЗ
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
                    Console.WriteLine("\nЗАДАНИЕ № 1"); HashSet<string> a = new HashSet<string>() { "хлеб", "масло" }; // Продукты в магазине A
                    HashSet<string> b = new HashSet<string>() { "сыр", "молоко" }; // Продукты в магазине B
                    HashSet<string> c = new HashSet<string>() { "хлеб", "молоко" }; // Продукты в магазине C

                    var unionSet = new HashSet<string>(a);
                    unionSet.UnionWith(b);
                    unionSet.UnionWith(c);

                    foreach (var product in unionSet)
                    {
                        Console.WriteLine(product);
                    }
                    break;
                    break;
                case "2":
                    Console.WriteLine("\nЗАДАНИЕ № 2");
                    Console.WriteLine("Введите строку с точкой в конце:");
                    string input = Console.ReadLine();
                    var letters = new HashSet<char>(input.Where(char.IsLetter));
                    Console.WriteLine($"Число различных букв: {letters.Count}");
                    break;
                case "3":
                    Console.WriteLine("\nЗАДАНИЕ № 3");
                    Console.WriteLine("Введите первую строку:");
                    string s1 = Console.ReadLine();
                    Console.WriteLine("Введите вторую строку:");
                    string s2 = Console.ReadLine();

                    var commonChars = new HashSet<char>(s1).Intersect(s2).OrderBy(c => c);
                    string s3 = new string(commonChars.ToArray());
                    Console.WriteLine($"Общие символы: {s3}");
                    break;
                case "4":
                    Console.WriteLine("\nЗАДАНИЕ № 4"); List<DateTime> dates = new List<DateTime>();
                    Console.WriteLine("Введите даты в формате дд.мм.гггг, разделенные пробелом:");
                    foreach (var dateString in Console.ReadLine().Split(' '))
                    {
                        if (DateTime.TryParseExact(dateString, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                        {
                            dates.Add(date);
                        }
                        else
                        {
                            Console.WriteLine($"Невозможно распознать дату: {dateString}");
                        }
                    }

                    Console.WriteLine("Выберите действие: [F1] - год с наименьшим номером, [F2] - весенние даты, [F3] - самая поздняя дата, [F10] - выход.");
                    var key = Console.ReadKey();
                    Console.WriteLine();
                    switch (key.Key)
                    {
                        case ConsoleKey.F1:
                            var minYear = dates.Min(date => date.Year);
                            Console.WriteLine($"Год с наименьшим номером: {minYear}");
                            break;
                        case ConsoleKey.F2:
                            Console.WriteLine("Весенние даты:");
                            var springDates = dates.Where(date => date.Month >= 3 && date.Month <= 5);
                            foreach (var date in springDates)
                            {
                                Console.WriteLine(date.ToString("dd.MM.yyyy"));
                            }
                            break;
                        case ConsoleKey.F3:
                            var latestDate = dates.Max();
                            Console.WriteLine($"Самая поздняя дата: {latestDate.ToString("dd.MM.yyyy")}");
                            break;
                        case ConsoleKey.F10:
                            Console.WriteLine("Выход из программы...");
                            break;
                        default:
                            Console.WriteLine("Неверная клавиша. Пожалуйста, выберите один из предложенных вариантов.");
                            break;
                    }
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

