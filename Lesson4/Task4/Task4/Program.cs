namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // library Book Inventory Management
            string[] bookTitles = { "Book 1", "Book 2", "Book 3", "Book 4", "Book 5" };
            string[] bookAuthors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
            string[] bookGenres = { "Fiction", "Mystery", "Romance", "Fantasy", "Sci-Fi" };
            int[] bookCopiesAvailable = { 5, 3, 7, 0, 2 };
            for (int i = 0;i<5;i++)
            {
                Console.WriteLine($"{bookTitles[i]}: {bookAuthors[i]},{bookGenres[i]},{ bookCopiesAvailable[i]}");
            }
            Console.WriteLine("enter the title of a book:");
            string input=Console.ReadLine().ToUpper();
            int c = 0;
            for(int i=0;i<bookTitles.Length;i++) { 
                if (input == bookTitles[i].ToUpper())
                {
                    Console.WriteLine($"{bookTitles[i]}: {bookAuthors[i]},{bookGenres[i]},{bookCopiesAvailable[i]}");
                    c++;
                }
            } if (c == 0)
            {
                Console.WriteLine("The book is not in the inventory.");
            }
                
        }
        
           
       
        
    }
}