namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int n=int.Parse(Console.ReadLine());
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j <=n; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+i*j);
                }
                Console.WriteLine("---------");
            }
        }
    }
}