using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Child(age 0-12):$5  Adult(age 13-64):$10 Senior(age 65<):$7
            // On Wednesday,ticket prices are recuded by $2
            byte childPrice = 5;
            byte adultPrice = 10;
            byte seniorPrice = 7;

            Console.Write("Enter your age:");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Enter the day of the week:");
            string day=Console.ReadLine();
            
            if(day == "Wednesday")
            {
                Console.WriteLine("Your ticket price is $2");
            }
            else
            {
                if(age>=0 && age <= 12)
                {
                    Console.WriteLine("Your ticket price is $"+childPrice);
                }else if (age >= 13 && age <= 64)
                {
                    Console.WriteLine("Your ticket price is $"+adultPrice);
                }else if (age >= 65)
                {
                    Console.WriteLine("Your ticket price is $"+seniorPrice);
                }
            }
            Console.ReadLine();
        }
    }
}
