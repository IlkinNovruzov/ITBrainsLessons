namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };
            Console.WriteLine(theLargestElement(nums));
            Console.WriteLine(theSmallestElement(nums));
            Console.WriteLine(sumElements(nums));
            Console.WriteLine(countElement(nums,9));
            betweenBounds(nums,10,30);
        }
        static int theLargestElement(int[] nums)
        {    int a = nums[0];
            for(int i=0; i < nums.Length-1; i++)
            {
                
                if (a < nums[i+1])
                {
                    a = nums[i+1];
                }
            }
            
          
            return a;
        }
        static int theSmallestElement(int[] nums)
        {
            int a = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {

                if (a > nums[i + 1])
                {
                    a = nums[i + 1];
                }
            }


            return a;
        }
        static int sumElements(int[] nums)
        {
            int sum=0;
            foreach (var item in nums)
            {
                 sum = sum + item;
            }
            
            return sum;
        } 
        static int countElement(int[] nums,int number)
        {
            int count=0;
            foreach (var item in nums)
            {
                if(item == number)
                {
                    count++;
                }
            }

            return count;
        }
        static void betweenBounds(int[] nums,int b1,int b2)
        {
            int[] result = {} ;
            foreach (var item in nums)
            {
                if (item > b1 && item < b2)
                {
                    result=result.Append(item).ToArray(); 
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}