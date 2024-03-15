using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMESPACE
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

                    break;
                case "2":
                    Console.WriteLine("\nЗАДАНИЕ № 2");

                    break;
                case "3":
                    Console.WriteLine("\nЗАДАНИЕ № 3");

                    break;
                case "4":
                    Console.WriteLine("\nЗАДАНИЕ № 4");

                    break;
                case "5":
                    Console.WriteLine("\nЗАДАНИЕ № 5");

                    break;
                case "6":
                    Console.WriteLine("\nЗАДАНИЕ № 6");

                    break;
                case "7":
                    Console.WriteLine("\nЗАДАНИЕ № 7");

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
                "6 Задача \n" +
                "7 Задача \n" + "\nВЫБОР: "
                );
            string command = (Console.ReadLine());
            GO(command);
        }
    }
}

