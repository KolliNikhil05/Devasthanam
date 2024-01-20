using System;

namespace ProgramsSwitch
{
    internal class ReverseTheCase
    {
        public void ReverseCase()
        {
            Console.Write("Please Enter a Name: ");
            string name = Console.ReadLine();
            string result = "";

            for (int i=0; i < name.Length; i++)
            {
                char reverseCase = name[i];

                if (char.IsUpper(reverseCase))
                {
                    result += char.ToLower(reverseCase);
                }
                else if (char.IsLower(reverseCase))
                {
                    result += char.ToUpper(reverseCase);
                }
                else
                {
                    result += reverseCase;
                }
            }

            Console.WriteLine(result);
        }

    }
}




 