namespace program
{
    internal class table
    {
        public void multiplyTable()
        {
            Console.WriteLine("enter number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num} table");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} multiply {i}= {num * i}");
            }
        }
    }
}