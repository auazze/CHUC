int[] array =  new int[5];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 15000);
        Console.WriteLine($"{i + 1}th element: {array[i]}");
}

Console.WriteLine("__________________________________________________");

// или так
for (int keys = 0; keys < array.Length; keys++)
{
    Console.WriteLine($"{keys + 1}th element: {array[keys]}");
}

Console.WriteLine("__________________________________________________");

int up = 2;
for (int j = 0; j < array.Length; j++)
{
    array[j] *= up;
    Console.WriteLine($"Elevated: {array[j]}");
}

Console.WriteLine("__________________________________________________");

for (int q = array.Length - 1; q >= 0; q--)
{
    Console.WriteLine($"Reverse: {array[q]}");
}

Console.WriteLine("__________________________________________________");

int max = array.Max();
Console.WriteLine($"Max number is: {max}");