using System.Collections;
using System.ComponentModel;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList shoppingList = new ArrayList();

            var example = new
            {
                Category = "auto",
                Name = "BMW",
                Price = 45000
            };
            shoppingList.Add(example);

            int choice = 0;

            while (choice < 3)
            {
                Console.WriteLine("1.Add Shopping Item\n" +
                    "2.Display Item by Category\n" +
                    "3.Exit");
                Console.Write("Enter choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddItem(shoppingList);
                        break;
                    case 2:
                        DisplayItem(shoppingList);
                        break;
                    case 3:
                        Console.WriteLine("Exited");
                        choice = 3;
                        break;
                    default:
                        Console.WriteLine("There is not choice.");
                        break;
                }
                Console.WriteLine();

            }

        }
        static void AddItem(ArrayList list)
        {
            Console.Write("Enter item count:");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}.Item");
                Console.Write("Enter category:");
                string itemCategory = Console.ReadLine();
                Console.Write("Enter item name:");
                string itemName = Console.ReadLine();
                Console.Write("Enter item price:");
                double itemPrice = double.Parse(Console.ReadLine());
                var shoppingItem = new
                {
                    Category = itemCategory,
                    Name = itemName,
                    Price = itemPrice
                };
                list.Add(shoppingItem);
                Console.WriteLine("Item Added.");
            }
        }
        static void DisplayItem(ArrayList list)
        {
            Console.WriteLine("Categories:");
            foreach (dynamic item in list)
            {
                Console.WriteLine(item.Category);
            }
            Console.Write("Enter category:");
            string category = Console.ReadLine().ToUpper();
            int c = 0;
            foreach (dynamic item in list)
            {
                if (category == item.Category.ToUpper())
                {
                    Console.WriteLine(item.Name + " $" + item.Price);
                    c++;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("There is not category");
            }


        }
    }
}