namespace programs
{
    internal class checkpositive
    {
        public void checkPositiveNum()
        {
            Console.WriteLine("enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if (num == 0)
            {
                Console.WriteLine($"{num} is Zero");
            }
            else
            {
                Console.WriteLine($"{num} is negitive");
            }
        }
    }
}
