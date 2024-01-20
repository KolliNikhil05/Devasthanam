namespace program
{
    internal class palindrome
    {
        public void checkPalindrome()
        {
            Console.WriteLine("enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rev = 0;
            int res;
            while (num > 0)
            {
                res = num % 10;
                rev = rev * 10 + res;
                num /= 10;
            }
            if (temp == rev)
            {
                Console.WriteLine($"{temp} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{temp} is not a palindrome");
            }
        }
    }
}