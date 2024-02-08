// МОЖНО БЫЛО ЧЕРЕЗ СВИТЧ-КЕЙС, НО МЫ ЛЮБИМ МАССИВЫ!
namespace Books
{
    public class Books
    {
        readonly string[] genres = ["Modern", "Modern", "Modern", "Modern", "Classic", "Classic", "Classic", "Classic"];
        readonly string[] authors = ["Michel Houellebecq", "Michel Houellebecq", "Michel Houellebecq", "Michel Houellebecq", "Niccolò Machiavelli", "Leo Tolstoy", "Erich Maria Remarque", "Erich Maria Remarque"];
        readonly string[] titles = ["Atomised", "Platform", "Whatever", "The Possibility of an Island", "The Prince", "War and Peace", "All Quiet on the Western Front", "A Time to Love and a Time to Die"];

        static void Main(string[] args)
        {
            Books myBooks = new();
            myBooks.Jooks();
        }

        public void Jooks()
        {
            Console.WriteLine($"Dunno what to read ??? Do u wanna see my library ? (1 - yes, 2 - no)");
            int yesno1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int yes1 = 1;
            int no1 = 2;
            if (yesno1 == yes1)
            {
                Console.WriteLine("Now u can see the genres, author and titles of books I have.");
                Console.WriteLine(" ");
                Console.WriteLine("Genres: Modern and Classic");
                Console.WriteLine("Authors: Michel Houellebecq, Niccolò Machiavelli, Leo Tolstoy and Erich Maria Remarque");
                Console.WriteLine("Titles: \"Atomised\", \"Platform\", \"Whatever\", \"The Possibility of an Island\", \"The Prince\", \"War and Peace\", \"All Quiet on the Western Front\", \"A Time to Love and a Time to Die\"");

                Console.WriteLine(" ");
                Console.WriteLine(" ");

                bool donotmiss = true;
                while (donotmiss)
                {
                    Console.WriteLine("Do u wanna choose a book from the library ? (1 - yes, 2 - no)");
                    int yesno2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    int yes2 = 1;
                    int no2 = 2;
                    if (yesno2 == 1)
                    {
                        Console.WriteLine($"Great! Input a title from the list I wrote above to select a certain book from the library I have (input \"1\")\nOr... u wanna random ur choice (input \"2\")?");
                        int yesno3 = int.Parse(Console.ReadLine());
                        int yes3 = 1;
                        int no3 = 2;
                        if (yesno3 == yes3)
                        {
                            Console.WriteLine("Input a title of a book");
                            string titlechoice = Console.ReadLine();
                            bool found = false;
                            for (int titlechoiceindex = 0; titlechoiceindex < titles.Length; titlechoiceindex++)
                            {
                                if (titles[titlechoiceindex].IndexOf(titlechoice, StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    Console.WriteLine($"You chose the {titles[titlechoiceindex]} literary work by {authors[titlechoiceindex]} author in the {genres[titlechoiceindex]} genre!\nGo find .pdf and start training ur brain!");
                                    found = true;
                                    break;
                                }
                            }
                            if (!found)
                            {
                                Console.WriteLine("Book not found, try again.");
                            }
                        }
                        else
                        {
                            Random random = new Random();
                            int i = random.Next(0, titles.Length);
                            Console.WriteLine($"You chose the {titles[i]} literary work by {authors[i]} author in the {genres[i]} genre!\nGo find .pdf and start training ur brain!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Okay, take a break, train other mucles and come back, sucker!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Okay...please, press any key.");
                Console.ReadKey();
                while (true)
                {
                    Console.WriteLine("STAY STUPID, SUCKER");
                }                
            }            
        }
    }
}