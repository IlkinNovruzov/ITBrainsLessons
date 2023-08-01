using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gradeCalculator();
        }
        static void gradeCalculator(){  
            // A(90-100) B(80-89) C(70-79) D(60-69) F(0-59)
            Console.Write("Enter your score:");
            byte score=byte.Parse(Console.ReadLine());
            if(score>=90 && score <= 100)
            {
                Console.WriteLine("Your grade is A.");
            }else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("Your grade is B.");
            }else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("Your grade is C.");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("Your grade is D.");
            }
            else if (score >= 0 && score <= 59)
            {
                Console.WriteLine("Your grade is F.");
            }
            else
            {
                Console.WriteLine("ERROR! There is no such score.");
            }
        }
    }
}
