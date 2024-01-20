namespace program
{
    internal class operations
    {
        public void performOperations()
        {
            Console.WriteLine("enter number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int mul = num1 * num2;
            int div = num1 / num2;
            int sub = num1 - num2;
            Console.WriteLine($" sum of {num1} and {num2}is:{sum}");
            Console.WriteLine($" multiply of {num1} and {num2}is:{mul}");
            Console.WriteLine($"division of {num1} and {num2}is:{div}");
            Console.WriteLine($" subtraction of {num1} and {num2}is:{sub}");
        }

    }
}