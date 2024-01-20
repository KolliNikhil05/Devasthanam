

namespace programs
{
    internal class sumDigits
    {
        public void sumOfDigits()
        {
            Console.WriteLine("enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int dig;
            while (num > 0)
            {
                dig = num % 10;
                sum += dig;
                num /= 10;
            }
            Console.WriteLine($"SUM OF INDIVIDUAL DIGITS IS:{sum}");
        }
        
    }
}
