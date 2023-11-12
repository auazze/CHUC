using System;

class Tasks
{
    static void Main()
    {
        int[] hours = { 3, 4, 7, 9, 11, 12, 13 };
        string[] tasks = { "task 1", "task 2", "task 3", "task 4", "task 5", "task 6", "task 7" };
        for (int i = 0; i < hours.Length; i+=1)
        {
            Console.WriteLine($"For {tasks[i]} need to work for {hours[i]} hours");
        }

        int TotalHours = 0;
        int ii = 0;
        while( ii < hours.Length)
        {
            TotalHours += hours[ii];
            ii+=1;

        }
        Console.WriteLine(
            $"\nNeeds total {TotalHours} hours for week's tasks");

        int DayIndex;
        string[] DayName = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        do
        {
            Console.WriteLine($"\nEnter day's number of the week: ");
        }
        while (!int.TryParse(Console.ReadLine(), out DayIndex) || DayIndex < 1 || DayIndex >= 7);
        string Day = DayName[DayIndex - 1];
        Console.WriteLine($"\nWe did {tasks[DayIndex]} in {hours[DayIndex]} hours in the {Day}");
    }


}
