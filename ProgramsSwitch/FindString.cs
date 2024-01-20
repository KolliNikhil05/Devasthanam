namespace ProgramsSwitch
{
    internal class FindString
    {
        //Find String :  Create a function that finds the word
        public void NameSearch()
        {
            Console.Write("Please Enter the Name: ");
            string word = Console.ReadLine();
            Console.Write("Enter the word to find: ");
            string find = Console.ReadLine();
            string result = FindingWord(word, find);
            Console.WriteLine(result);
        }
        static string FindingWord(string asd, string find)
        {
            if (asd.ToLower().Contains(find.ToLower()))
            {
                return "Found";
            }
            else
            {
                return "Not found";
            }
        }
    }
}

       
      