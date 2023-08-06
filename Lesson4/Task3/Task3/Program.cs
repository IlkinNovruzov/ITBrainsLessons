namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator();
        }
        static void calculator()
        {
            Console.Write("Enter number:");
            double num1=double.Parse(Console.ReadLine());
            Console.Write("Enter number:");
            double num2=double.Parse(Console.ReadLine());
            Console.WriteLine("1:+\n" +
                              "2:-\n" +
                              "3:*\n" +
                              "4:/\n");
            Console.Write("Choose operation number:");
            string operation = Console.ReadLine();
            switch (operation) {
                case "1":
                    Console.WriteLine($"{num1}+{num2}={num1 + num2}");
                    break;
                case "2":
                    Console.WriteLine($"{num1}-{num2}={num1 - num2}");
                    break;
                case "3":
                    Console.WriteLine($"{num1}*{num2}={num1 * num2}");
                    break;
                case "4":
                    Console.WriteLine($"{num1}/{num2}={num1 / num2}");
                    break;
                default:
                    Console.WriteLine("There is not operation.");
                    break;
            }
        }
    }
}