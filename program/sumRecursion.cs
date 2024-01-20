namespace program
{
    internal class sumRecursion
    {
        public static int sumByRecursion(int num)
        {
            if (num < 10)
            {
                return num;
            }
            else
            {
                int lastDigit = num % 10; // ld = 145%10= 5
                int remainingDigits = num / 10; // rd = 145/10= 14
                return lastDigit + sumByRecursion(remainingDigits);
                // 5+recursion(14)
                //return num % 10 + sumOfRecursion(num / 10);
            }
        }

    }
}