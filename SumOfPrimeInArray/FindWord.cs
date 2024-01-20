namespace Program
{
    internal class FindWord
    {
        static void Main()
        {
            Console.Clear();

            Console.Write("Enter the string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter the word to find: ");
            string wordToFind = Console.ReadLine();

            string result = FindingWord(inputString, wordToFind);
            Console.WriteLine(result);
        }

        static string FindingWord(string inputString, string wordToFind)
        {
            if (inputString.ToLower().Contains(wordToFind.ToLower()))
            {
                return "Found";
            }
            else
            {
                return "Given string Not found";
            }
        }
        //static string FindingWord(string inputString, string wordToFind)
        //{
        //    inputString = inputString.ToLower();
        //    wordToFind = wordToFind.ToLower();

        //    for (int i = 0; i <= inputString.Length - wordToFind.Length; i++)
        //    {
        //        bool found = true;
        //        for (int j = 0; j < wordToFind.Length; j++)
        //        {
        //            if (inputString[i + j] != wordToFind[j])
        //            {
        //                found = false;
        //                break;
        //            }
        //        }

        //        if (found)
        //        {
        //            return "Found";
        //        }
        //    }

        //    return "Given string Not found";
        //}
    }
}
