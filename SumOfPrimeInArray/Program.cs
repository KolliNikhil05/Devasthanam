using System.Reflection.Metadata.Ecma335;

namespace SumOfPrimeInArray
{
    public class Program
    {

      
            static void Main(string[] args)

            {
                int[] nums = { 7, 5, 85, 9, 11, 23, 18 };
               
                Console.WriteLine("Sum of all primes in array: " + test(nums));
            }
            public static int test(int[] arr)
            {
                int result = 0;
                foreach (int number in arr)
                {
                    if (IsPrime(number, number / 2))
                    {
                    Console.WriteLine("Array Elements from above array are:");
                    Console.WriteLine(number);
                        result += number;
                    }
                }
                return result;
            }

            static bool IsPrime(int n1, int i)
            {
                if (i == 1)
                {
                    return true;
                }
                else
                {
                    if (n1 % i == 0)
                        return false;
                    else
                        return IsPrime(n1, i - 1);
                }
            }
    }
}



 