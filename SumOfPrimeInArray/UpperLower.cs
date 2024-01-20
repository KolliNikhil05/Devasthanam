using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimeInArray
{
    internal class UpperLower
    {

        static void Main()
        {
             Console.Clear();

            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            string reversedString = ReverseCase(inputString);

            Console.WriteLine("Reversed Case: " + reversedString);
        }

        static string ReverseCase(string inputString)
        {
            char[] charArray = inputString.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
                else if (char.IsLower(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
                
            }

            return new string(charArray);
        }
       

    }
}
