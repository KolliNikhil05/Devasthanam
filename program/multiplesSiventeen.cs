namespace program
{
    internal class multiplesSiventeen
    {
        public void multiplesOfSiventeen()
        {
            Console.WriteLine("multiples of siventeen under 100");
            for (int i = 1; i < 100; i++)
            {
                if (i % 17 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}