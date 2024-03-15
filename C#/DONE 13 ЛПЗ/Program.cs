using System;

namespace DONE_13_ЛПЗ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1: Передача параметров по значению
            int value = 10;
            DoubleValue(value);
            Console.WriteLine($"После DoubleValue: {value} (оригинальное значение не изменяется)");

            // Задача 2: Передача параметров по ссылке (ref)
            int a = 5, b = 10;
            Swap(ref a, ref b);
            Console.WriteLine($"После Swap: a = {a}, b = {b}");

            // Задача 3: Выходные параметры (out)
            int dividend = 10, divisor = 3;
            Divide(dividend, divisor, out int result, out int remainder);
            Console.WriteLine($"Результат деления: {result}, Остаток: {remainder}");

            // Задача 4: Входные параметры (in)
            int[] array = { 1, 2, 3, 4, 5 };
            PrintArrayInfo(in array);
        }

        // Метод для Задачи 1
        static void DoubleValue(int parameter)
        {
            parameter *= 2;
            Console.WriteLine($"Внутри DoubleValue: {parameter}");
        }

        // Метод для Задачи 2
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Метод для Задачи 3
        static void Divide(int dividend, int divisor, out int result, out int remainder)
        {
            result = dividend / divisor;
            remainder = dividend % divisor;
        }

        // Метод для Задачи 4
        static void PrintArrayInfo(in int[] array)
        {
            Console.WriteLine($"Размер массива: {array.Length}, Первый элемент: {array[0]}");
            // array[0] = 10; // Эта строка вызовет ошибку компиляции, если её раскомментировать, так как array передан с модификатором in
        }
    }
}
