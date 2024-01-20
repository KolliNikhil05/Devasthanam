
namespace programs
{
    internal class swap
    {
        public void swapNum()
        {
            Console.WriteLine("enter 1st number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" number one is {number1}");
            Console.WriteLine($" number two is {number2}");
            int temp;
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($" number one is {number1}");
            Console.WriteLine($" number two is {number2}");
        }
    }
}
