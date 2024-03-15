using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE_11_ЛПЗ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1: Демонстрация соответствия параметров и аргументов по типу данных
            Console.WriteLine("Задача 1:");
            DisplayTypeSize(5);
            DisplayTypeSize(5.0);
            DisplayTypeSize("Hello");

            Console.WriteLine("\nЗадача 2:");
            // Задача 2: Демонстрация необязательных параметров
            CreateGreetingMessage("Stepan");
            CreateGreetingMessage("Stepan", "Добро пожаловать");

            Console.WriteLine("\nЗадача 3:");
            // Задача 3: Демонстрация именованных параметров
            PrintStudentDetails(name: "Степан", age: 26, course: "2-ой", specialty: "Программист / Разработчик");
        }

        // Методы для Задачи 1
        static void DisplayTypeSize(int value)
        {
            Console.WriteLine($"int: {sizeof(int)} bytes");
        }

        static void DisplayTypeSize(double value)
        {
            Console.WriteLine($"double: {sizeof(double)} bytes");
        }

        static void DisplayTypeSize(string value)
        {
            Console.WriteLine($"string: Size depends on content. Length = {value.Length}");
        }

        // Метод для Задачи 2
        static void CreateGreetingMessage(string name, string greeting = "Привет")
        {
            Console.WriteLine($"{greeting}, {name}!");
        }

        // Метод для Задачи 3
        static void PrintStudentDetails(string name, int age, string course, string specialty)
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Курс: {course}, Специальность: {specialty}");
        }
    }

}

