using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE_7_ЛПЗ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WehereToGo();
        }


        public static void GO(string command)
        {
            Random rnd = new Random();

            switch (command)
            {
                case "1":
                    Console.WriteLine("\nЗАДАНИЕ № 1");
                    Console.WriteLine("Введите количество строк и столбцов через пробел:");
                    string[] sizes = Console.ReadLine().Split();
                    int rows = int.Parse(sizes[0]);
                    int cols = int.Parse(sizes[1]);

                    int[,] array = new int[rows, cols];
                    int negativeCount = 0;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            array[i, j] = rnd.Next(-10, 10);
                            Console.Write(array[i, j] + " ");
                            if (array[i, j] < 0) negativeCount++;
                        }
                        Console.WriteLine();
                    }
                    bool hasTwoNegatives = negativeCount == 2;
                    Console.WriteLine($"В массиве ровно два отрицательных элемента? {(hasTwoNegatives ? "Да" : "Нет")}");
                    break;
                case "2":
                    Console.WriteLine("\nЗАДАНИЕ № 2");
                    Console.WriteLine("Введите n:");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write((n - i) + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("\nЗАДАНИЕ № 3");
                    Console.WriteLine("Введите количество строк и столбцов через пробел:");
                    string[] maxSizes = Console.ReadLine().Split();
                    int maxRows = int.Parse(maxSizes[0]);
                    int maxCols = int.Parse(maxSizes[1]);

                    int[,] arrayMax = new int[maxRows, maxCols];
                    for (int i = 0; i < maxRows; i++)
                    {
                        int maxValue1 = int.MinValue;
                        int maxIndex = -1;
                        for (int j = 0; j < maxCols; j++)
                        {
                            arrayMax[i, j] = rnd.Next(1, 10);
                            Console.Write(arrayMax[i, j] + " ");
                            if (arrayMax[i, j] > maxValue1)
                            {
                                maxValue1 = arrayMax[i, j];
                                maxIndex = j;
                            }
                        }
                        if (maxIndex != -1) arrayMax[i, maxIndex] *= -1;
                        Console.WriteLine();
                    }
                    Console.WriteLine("Изменённый массив:");
                    for (int i = 0; i < maxRows; i++)
                    {
                        for (int j = 0; j < maxCols; j++)
                        {
                            Console.Write(arrayMax[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "4":
                    Console.WriteLine("\nЗАДАНИЕ № 4");
                    Console.WriteLine("Введите размеры матрицы M и N через пробел:");
                    string[] sizes1 = Console.ReadLine().Split();
                    int M1 = int.Parse(sizes1[0]);
                    int N1 = int.Parse(sizes1[1]);
                    int[,] matrix1 = new int[M1, N1];
                    Random rnd1 = new Random();
                    for (int i = 0; i < M1; i++)
                    {
                        for (int j = 0; j < N1; j++)
                        {
                            matrix1[i, j] = rnd1.Next(-10, 11);
                            Console.Write(matrix1[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Среднее арифметическое элементов в строках с нечетным номером (по порядку, начиная с 1):");
                    for (int i = 0; i < matrix1.GetLength(0); i += 2) // Теперь начинаем с 0, чтобы считать "нечетные" строки с 1
                    {
                        double sum = 0;
                        for (int j = 0; j < matrix1.GetLength(1); j++)
                        {
                            sum += matrix1[i, j];
                        }
                        Console.WriteLine($"Строка {i + 1}: {sum / N1}");
                    }
                    break;
                case "5":
                    Console.WriteLine("\nЗАДАНИЕ № 5");
                    Console.WriteLine("Введите размеры матрицы M и N через пробел:");
                    string[] sizes2 = Console.ReadLine().Split();
                    int M2 = int.Parse(sizes2[0]);
                    int N2 = int.Parse(sizes2[1]);
                    int[,] matrix2 = new int[M2, N2];
                    Random rnd2 = new Random();
                    for (int i = 0; i < M2; i++)
                    {
                        for (int j = 0; j < N2; j++)
                        {
                            matrix2[i, j] = rnd2.Next(-10, 11);
                            Console.Write(matrix2[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    int minRow = 0, maxRow = 0, minValue = matrix2[0, 0], maxValue = matrix2[0, 0];
                    for (int i = 0; i < M2; i++)
                    {
                        for (int j = 0; j < N2; j++)
                        {
                            if (matrix2[i, j] < minValue)
                            {
                                minValue = matrix2[i, j];
                                minRow = i;
                            }
                            if (matrix2[i, j] > maxValue)
                            {
                                maxValue = matrix2[i, j];
                                maxRow = i;
                            }
                        }
                    }
                    for (int j = 0; j < N2; j++)
                    {
                        int temp = matrix2[minRow, j];
                        matrix2[minRow, j] = matrix2[maxRow, j];
                        matrix2[maxRow, j] = temp;
                    }
                    Console.WriteLine("Матрица после перестановки:");
                    for (int i = 0; i < M2; i++)
                    {
                        for (int j = 0; j < N2; j++)
                        {
                            Console.Write(matrix2[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "6":
                    Console.WriteLine("\nЗАДАНИЕ № 6");
                    Console.WriteLine("Введите размер матрицы M (квадратная):");
                    int M3 = int.Parse(Console.ReadLine());
                    int[,] matrix3 = new int[M3, M3];
                    Random rnd3 = new Random();
                    for (int i = 0; i < M3; i++)
                    {
                        for (int j = 0; j < M3; j++)
                        {
                            matrix3[i, j] = rnd3.Next(-10, 11);
                            Console.Write(matrix3[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Среднее арифметическое элементов каждой диагонали, параллельной главной:");
                    for (int k = 0; k < M3; k++)
                    {
                        double sum = 0;
                        int count = 0;
                        for (int i = 0, j = k; j >= 0 && i < M3; i++, j--)
                        {
                            sum += matrix3[i, j];
                            count++;
                        }
                        if (count > 0)
                        {
                            Console.WriteLine($"Диагональ {k + 1}: {sum / count}");
                        }
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
                "4 Задача \n" +
                "5 Задача \n" +
                "6 Задача \n" + "\nВЫБОР: "
                );
            string command = (Console.ReadLine());
            GO(command);
        }
    }
}
