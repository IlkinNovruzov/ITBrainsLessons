
using System.Runtime.CompilerServices;

namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            Console.WriteLine($"Is Odd:{a.IsOdd()}");
            Console.WriteLine($"Is Even:{a.IsEven()}");

            string s = "ilkin2";
            Console.WriteLine($"Is Contains Digit:{s.IsContainsDigit()}");

            foreach (var item in s.GetValueIndexes('i'))
            {
                Console.WriteLine(item);
            }

            int[] array = {2,3,1,4,7,5,9,2,23,12,2,9,3,7};

            foreach (var item in array.GetValueIndexes(7))
            {
                Console.WriteLine(item);
            }


        }
    }
    static class ExtentionMethods
    {
        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsOdd(this int number)
        {
            if (!(number % 2 == 0))
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(this string str)
        {
            foreach (var item in str)
            {
                if (Char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static int[] GetValueIndexes(this string str, char c)
        {
            int[] index = { };
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    index = index.Append(i).ToArray();
                }
            }
            return index;
        }
        public static int[] GetValueIndexes(this int[] array, int num)
        {
            int[] index = { };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    index = index.Append(i).ToArray();
                }
            }
            return index;
        }

    }
}