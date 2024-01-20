namespace ProgramsSwitch
{
    internal class SmallestElement
    {
        public void SmallestInArray()
        {
            Console.WriteLine("Enter size of Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] ArrayElements = new int[size];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < size; i++)
            {
                ArrayElements[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    if (ArrayElements[j] < ArrayElements[k])
                    {
                        int temp = ArrayElements[j];
                        ArrayElements[j] = ArrayElements[k];
                        ArrayElements[k] = temp;
                    }
                }
            }
            Console.WriteLine("Smallest Element In Array is:" + ArrayElements[0]);
        }
    }
}
