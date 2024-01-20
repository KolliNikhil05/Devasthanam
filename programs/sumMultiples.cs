

namespace programs
{
    internal class sumMultiples
    {
        public void sumOfMultiples()
        {
            Console.WriteLine("enter Range to check sum of multiples of 3 & 5 :");
            var range = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < range; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"sum of multiples is: {sum}");
        }

    }
}
