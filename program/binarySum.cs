namespace program
{
    internal class binarySum
    {
        public void sumOfBinary()
        {
            Console.WriteLine("enter binary number 1");
            string bin1 = Console.ReadLine();
            Console.WriteLine("enter binary number 2");
            string bin2 = Console.ReadLine();
            int num1 = Convert.ToInt32(bin1, 2);
            int num2 = Convert.ToInt32(bin2, 2);
            int sum = num1 + num2;
            string binarySum = Convert.ToString(sum, 2);
            Console.WriteLine($"sum of binary is {bin1}+{bin2}: {binarySum}");

        }
    }
}

