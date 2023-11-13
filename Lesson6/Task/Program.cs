using System.Collections;
using System.Transactions;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList bookList = new ArrayList();
            ArrayList bookTitle = new ArrayList();
            ArrayList bookAuthor = new ArrayList();
            ArrayList bookPrice = new ArrayList();
            Console.WriteLine("Add book-1\n" +
                "Remove book-2\n" +
                "Calculate value-3\n" +
                "Exit-4");
            int j = 0;
            while(j<4) { Console.WriteLine("Select:");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    AddBook(bookTitle, bookAuthor, bookPrice);
                    break;
                case 2:
                    RemoveBook(bookTitle, bookAuthor, bookPrice);
                    break;
                case 3:
                    CalculateTotalValue(bookPrice); 
                    break;
                        case 4:
                        Console.WriteLine("Exited.");
                        j = 4;
                        break;
                default:
                    Console.WriteLine("There is not option.");
                    break;
            } }
           








        }
        static void AddBook(ArrayList bookTitle, ArrayList bookAuthor, ArrayList bookPrice)
        {
            Console.Write("Enter count of books:");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter title of book:");
                string title = Console.ReadLine();
                Console.Write("Enter author of book:");
                string author = Console.ReadLine();
                Console.Write("Enter price of book:");
                int price = int.Parse(Console.ReadLine());


                bookTitle.Add(title);
                bookAuthor.Add(author);
                bookPrice.Add(price);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Book {i + 1} : {bookTitle[i]},{bookAuthor[i]},{bookPrice[i]}");
            }
        }
        static void RemoveBook(ArrayList bookTitle, ArrayList bookAuthor, ArrayList bookPrice)
        {
            Console.WriteLine("enter booktitle:");
            string input = Console.ReadLine();
            int c = 0;
            for (int i = 0; i < bookTitle.Count; i++)
            {
                if (bookTitle[i] == input)
                {
                    bookTitle.RemoveAt(i);
                    bookAuthor.RemoveAt(i);
                    bookPrice.RemoveAt(i);
                    Console.WriteLine("book is deleted");
                    c++;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("book is not found");
            }
        }
        static void CalculateTotalValue(ArrayList bookPrice)
        {
            double total = 0;
            foreach (double item in bookPrice)
            {
                Console.WriteLine(item);
                total = total + item;
            }
            Console.WriteLine("Total:"+total);
        }
    }
}