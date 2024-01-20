namespace program
{
    internal class reverse
    {
        public void reverseNum()
        {
            Console.WriteLine("enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int res;
            while (num > 0)
            {
                res = num % 10;
                rev = rev * 10 + res;
                num /= 10;
            }
            Console.WriteLine($"reverse of the number :{rev}");
        }

    }
}