using System;

namespace DONE_ЛПЗ_15
{
    class Book2
    {
        string title3;
        string author3;
        int year3;
        public Book2(string title3) : this(title3, "None", 0)
        {
            Console.WriteLine("3 задание");
            Console.WriteLine("Базовый конструктор с названием");
        }
        public Book2(string title3, string author3) : this(title3, author3, 0)
        {
            Console.WriteLine("3 задание");
            Console.WriteLine("Расширенный конструктор, который принимает title и author, и вызывает базовый конструктор");
        }
        public Book2(string title3, string author3, int year3)
        {
            //Console.WriteLine("3 задание");
            //Console.WriteLine("Расширенный конструктор, который принимает все три параметра");
            this.title3 = title3;
            this.author3 = author3;
            this.year3 = year3;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {this.title3}, Автор: {this.author3}, Год: {this.year3}");
        }
    }
}
