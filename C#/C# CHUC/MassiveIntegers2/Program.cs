using System;
using System.Linq;

namespace MassiveIntegers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random random = new Random();
            Console.WriteLine("Random: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 5);
                Console.Write($"{array[i]}");

            }
            Console.WriteLine("\n");
            Console.WriteLine("Random reverse: ");
            for (int q = array.Length - 1; q >= 0; q--)
            {
                Console.Write($"{array[q]}");
            }
            Console.WriteLine("\n");
            Array.Sort(array);
            Console.WriteLine("Sorted: ");
            for (int j = array.Length - 1; j >= 0; j--)
            {
                Console.Write($"{array[j]}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sorted reverse: ");
            for (int sr = 0; sr < array.Length; sr++)
            {

                Console.Write($"{array[sr]}");
            }            
        }
    }
}
