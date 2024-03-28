using System;

namespace DONE_ЛПЗ_15
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 задание
            Book book1 = new Book("Title1");
            Book book2 = new Book("Title2", "Author2");
            Book book3 = new Book("Title3", "Author3", 2024);
            Console.WriteLine("-----------------------------------------------------------------");
            // 2 задание
            Book1 book11 = new Book1("Title1");
            book11.DisplayInfo(); // Вывод информации о книге 1
            Book1 book22 = new Book1("Title2", "Author2");
            book22.DisplayInfo(); // Вывод информации о книге 2
            Book1 book33 = new Book1("Title3", "Author3", 2024);
            book33.DisplayInfo(); // Вывод информации о книге 3
            Console.WriteLine("-----------------------------------------------------------------");
            // 3 задание
            Book2 book111 = new Book2("Title1");
            book111.DisplayInfo(); // Вывод информации о книге 1
            Book2 book222 = new Book2("Title2", "Author2");
            book222.DisplayInfo(); // Вывод информации о книге 2
            Console.WriteLine("3 задание");
            Console.WriteLine("Расширенный конструктор, который принимает все три параметра");
            Book2 book333 = new Book2("Title3", "Author3", 2024);
            book333.DisplayInfo(); // Вывод информации о книге 3
            Console.WriteLine("-----------------------------------------------------------------");
            // 4 задание
            Student student = new Student
            {
                Name = "Алексей",
                Age = 21,
                University = "МГУ"
            };

            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, University: {student.University}");

        }
    }

    class Book
    {
        string title1;
        string author1;
        int year1;
        public Book(string bookTitle)
        {
            Console.WriteLine("В задании 1 не сказано выводить ^_^");
            Console.WriteLine("Только название");
            title1 = bookTitle;
            author1 = "Неизвестен";
            year1 = 0;
        }

        public Book(string bookTitle, string bookAuthor)
        {
            Console.WriteLine("В задании 1 не сказано выводить ^_^");
            Console.WriteLine("Название и автор");
            title1 = bookTitle;
            author1 = bookAuthor;
            year1 = 0;
        }

        public Book(string bookTitle, string bookAuthor, int bookYear)
        {
            Console.WriteLine("В задании 1 не сказано выводить ^_^");
            Console.WriteLine("Полная информация");
            title1 = bookTitle;
            author1 = bookAuthor;
            year1 = bookYear;
        }
    }
}
