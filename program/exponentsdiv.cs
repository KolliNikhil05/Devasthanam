namespace program
{
    internal class exponentsdiv
    {
        public void expdivision()
        {
            Console.Write("Enter base: ");
            double baseValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter  first exponent: ");
            int exponent1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second exponent: ");
            int exponent2 = Convert.ToInt32(Console.ReadLine());
            int resultExponent = exponent1 - exponent2;
            double result = Math.Pow(baseValue, resultExponent);

            Console.WriteLine($"{baseValue}^{exponent1} * {baseValue}^{exponent2} = {baseValue}^{resultExponent} = {result}");
        }
    }
}