namespace program
{
    internal class binarymul
    {
        public void multiplyOfBinary()
        {
            Console.WriteLine("enter binary number 1");
            string bin1 = Console.ReadLine();
            Console.WriteLine("enter binary number 2");
            string bin2 = Console.ReadLine();
            int num1 = Convert.ToInt32(bin1, 2);
            int num2 = Convert.ToInt32(bin2, 2);
            int mul = num1 * num2;
            string binaryMult = Convert.ToString(mul, 2);
            Console.WriteLine($"sum of binary is {bin1}*{bin2}: {binaryMult}");
        }

    }
}