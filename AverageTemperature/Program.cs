using System;
using System.IO;

class Tasks
{
    static void Main()
    {
        int[] temperatures = { 20, 11, 29, 33, 24, 5, 16 };
        Console.WriteLine("Weekly t: ");
        for (int day = 0; day < temperatures.Length; day++)
        {
            Console.WriteLine($"Day {day + 1}: {temperatures[day]} C");
        }
        int sum = 0;
        int DayOfWeek = 0;
        while(DayOfWeek < temperatures.Length)
        {
            sum += temperatures[DayOfWeek];
            DayOfWeek++;
        }

        double averageTemperature = (double)sum / temperatures.Length;
        Console.WriteLine($"Average t of the week: {averageTemperature} C");

        do
        {
            Console.WriteLine($"Write the number of the day of the week: ");
            if (int.TryParse(Console.ReadLine(), out int ChosenDay) && ChosenDay >= 1 && ChosenDay <= 7)
            {
                Console.WriteLine($"The temperature of {ChosenDay} day of week is: {temperatures[ChosenDay - 1]}");
                break;
            }
            else
            {
                Console.WriteLine("Try again.");
            }
        }
        while (true);
    }
}