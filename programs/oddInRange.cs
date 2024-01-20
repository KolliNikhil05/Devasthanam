namespace programs
{
    internal class oddInRange
    {
        public  void oddRange()
        {
            Console.WriteLine("enter the range:");
            int range = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < range; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }
            
    }
}
