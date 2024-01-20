

namespace program
{
    internal class heightCategorize
    {
        public void heights()
        {
            Console.WriteLine("Enter  the Height \n");
            float height = Convert.ToInt32(Console.ReadLine());
            
            //height = int.Parse(Console.ReadLine());
            if (height < 150.0)
                Console.WriteLine("Dwarf \n");
            else if ((height >= 150.0) && (height <= 165.0))
                Console.WriteLine(" Average Height \n");
            else if ((height >= 165.0) && (height <= 195.0))
                Console.WriteLine("Taller \n");
            else
                Console.WriteLine(" normal height \n");
        }
    }
}
