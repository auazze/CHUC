using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONE_8_ЛПЗ
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
                    Console.WriteLine("Введите число N (1<=N<=26):");
                    int N = int.Parse(Console.ReadLine());
                    char startChar = 'z';
                    for (int i = 0; i < N; i++)
                    {
                        Console.Write((char)(startChar - i) + " ");
                    }
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine("\nЗАДАНИЕ № 2");
                    Console.WriteLine("Введите строку:");
                    string input = Console.ReadLine();
                    string uppercased = input.ToUpper();
                    Console.WriteLine(uppercased);
                    break;
                case "3":
                    Console.WriteLine("\nЗАДАНИЕ № 3");
                    Console.WriteLine("Введите символ C:");
                    char C = Console.ReadLine()[0];
                    Console.WriteLine("Введите строку S:");
                    string S = Console.ReadLine();
                    Console.WriteLine("Введите строку S0 для вставки:");
                    string S0 = Console.ReadLine();
                    string result = S.Replace(C.ToString(), C + S0);
                    Console.WriteLine(result);
                    break;
                case "4":
                    Console.WriteLine("\nЗАДАНИЕ № 4");
                    Console.WriteLine("Введите строку, состоящую из русских слов:");
                    string sentence = Console.ReadLine();
                    string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int minLength = words.Length > 0 ? words.Min(word => word.Length) : 0;
                    Console.WriteLine($"Длина самого короткого слова: {minLength}");
                    break;
                case "5":
                    Console.WriteLine("\nЗАДАНИЕ № 5");
                    Console.WriteLine("Введите строку-предложение на русском языке:");
                    string sentenceK = Console.ReadLine();
                    Console.WriteLine("Введите число K (0 < K < 10):");
                    int K = int.Parse(Console.ReadLine());
                    StringBuilder encryptedSentence = new StringBuilder();
                    foreach (char ch in sentenceK)
                    {
                        if (char.IsLetter(ch) && ch != 'ё' && ch != 'Ё')
                        {
                            bool isUpper = char.IsUpper(ch);
                            char baseChar = isUpper ? 'А' : 'а';
                            int alphabetSize = 32;
                            char correctedChar = ch == 'ё' ? (char)('е' + 1) : ch;
                            char correctedBaseChar = isUpper && ch > 'Е' ? (char)(baseChar + 1) : baseChar;
                            int offset = (char.ToUpper(correctedChar) - correctedBaseChar + K) % alphabetSize;

                            if (ch >= 'е') offset = (offset + 1) % alphabetSize;

                            char newChar = (char)(correctedBaseChar + offset);
                            if (newChar > 'я') newChar = (char)(newChar - alphabetSize);
                            if (isUpper && newChar >= 'а') newChar = char.ToUpper(newChar);

                            encryptedSentence.Append(newChar);
                        }
                        else
                        {
                            encryptedSentence.Append(ch);
                        }
                    }
                    Console.WriteLine($"Зашифрованное предложение: {encryptedSentence}");
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
                "5 Задача \n" + "\nВЫБОР: "
                );
            string command = (Console.ReadLine());
            GO(command);
        }
    }
}

