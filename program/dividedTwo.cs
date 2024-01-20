namespace program
{
    internal class dividedTwo
    {
        public void dividedByTwo()
        {
            Console.WriteLine("enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is divisible by 2");
            }
            else
            {
                Console.WriteLine($"{num} is not divisible by 2");
            }
        }
    }
}