namespace ProgramsSwitch
{
    internal class MissingElementInArray
    {
        public void MissingInArray()
        {
            int[] inputarray = { 7, 2, 1, 4, 3, 5, 7, 8 };
            Array.Sort(inputarray);
            var missingElement = inputarray[0];
            for (int i = 0; i < inputarray.Length; i++)
            {
                if (!(inputarray[i] == missingElement))
                {
                    Console.WriteLine("The Missing Element is :" + missingElement);
                    break;
                }
                missingElement = missingElement + 1;

            }
            for (int i = 0; i < inputarray.Length - 1; i++)
            {
                if (inputarray[i] == inputarray[i + 1])
                {
                    Console.WriteLine("The repeated Element is:" + inputarray[i]);
                    break;
                }
            }
            
        }

    }
}


























//for (int j = 0; j < inputarray.Length; j++)
//{
//    for (int k = 0; k < inputarray.Length; k++)
//    {
//        if (inputarray[j] > inputarray[k])
//        {
//            int temp = inputarray[j];
//            inputarray[j] = inputarray[k];
//            inputarray[k] = temp;
//        }
//    }
//}