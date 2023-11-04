using System;

class TimeOfDayProgram
{
    static void Main()
    {
        Console.WriteLine("Введите время в формате 24-часового времени (например, 14:30): ");
        string input = Console.ReadLine();

        if (TimeSpan.TryParse(input, out TimeSpan time))
        {
            if (time.Hours >= 6 && time.Hours < 12)
            {
                Console.WriteLine("Доброе утро!");
            }
            else if (time.Hours >= 12 && time.Hours < 18)
            {
                Console.WriteLine("Добрый день!");
            }
            else if (time.Hours >= 18 && time.Hours < 22)
            {
                Console.WriteLine("Добрый вечер!");
            }
            else
            {
                Console.WriteLine("Спокойной ночи!");
            }
        }
        else
        {
            Console.WriteLine("Введено некорректное время. Попробуйте еще раз.");
        }

        // Задержка консоли
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
