using System;

namespace DONE_ЛПЗ_15
{
    class Book1
    {
        string title2;
        string author2;
        int year2;
        public Book1(string title2)
        {
            Console.WriteLine("2 задание");
            Console.WriteLine("Только название");
            this.title2 = title2;
            this.author2 = "No author";
            this.year2 = 0;
        }
        public Book1(string title2, string author2)
        {
            Console.WriteLine("2 задание");
            Console.WriteLine("Название и автор");
            this.title2 = title2;
            this.author2 = author2;
            this.year2 = 0;
        }
        public Book1(string title2, string author2, int year2)
        {
            Console.WriteLine("2 задание");
            Console.WriteLine("Полная информация");
            this.title2 = title2;
            this.author2 = author2;
            this.year2 = year2;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {this.title2}, Автор: {this.author2}, Год: {this.year2}");
        }
    }
}
