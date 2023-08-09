using System.Collections;
using System.Runtime.CompilerServices;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList shoppingList = new ArrayList() { "Milk", "Bread" };
            Console.WriteLine("Select an option\n" +
                "1. Add item\n" +
                "2. Display list\n" +
                "3. Check item\n" +
                "4. Exit");
            int j = 0;
            while (j < 4)
            {
                Console.Write("Select:");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Write("How many items do you want to add:");
                        int count = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= count; i++)
                        {
                            Console.Write(i + ".item:");
                            string addItem = Console.ReadLine();
                            shoppingList.Add(addItem);

                        }
                        Console.WriteLine("------------");
                        foreach (var item in shoppingList)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        foreach (var item in shoppingList)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter item you want to check:");
                        string checkItem = Console.ReadLine().ToUpper();
                        int c = 0;
                        foreach (string item in shoppingList)
                        {
                            if (item.ToUpper() == checkItem)
                            {
                                Console.WriteLine("This item has been added.");
                                c++;
                            }
                        }
                        if (c == 0)
                        {
                            Console.WriteLine("This item has not been added.");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        j = 4;
                        Console.WriteLine("Exited");
                        break;
                    default:
                        Console.WriteLine("There is not option.");
                        break;
                }

            }



        }
    }
}