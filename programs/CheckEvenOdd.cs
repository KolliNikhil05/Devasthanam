namespace programs
{
    public class CheckEvenOdd
    {
        public void checkNumberEvenOdd()
        {
            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}
