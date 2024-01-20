namespace program
{
    internal class largestNumber
    {
        public void largestNum()
        {
            Console.WriteLine("enter number 1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2 :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"{num2} is greater than {num1}");
            }
            else
            {
                Console.WriteLine($"{num1} is equal  to {num2}");
            }
        }
    }
}