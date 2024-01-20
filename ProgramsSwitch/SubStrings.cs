using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsSwitch
{
    internal class SubStrings
    {
        public void findingSubString()
        {

            Console.Write("Enter a string: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Sub Strings:");

            for (int i = 0; i < Name.Length; i++)
            {
                for (int j = i; j < Name.Length; j++)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(Name[k]);
                    }
                    Console.WriteLine();
                }
            }
           
        }
    }
}
























//Console.WriteLine("Enter a string");
//string name = Console.ReadLine();
//int size = name.Length;
//for (int i = 0; i < size; i++)
//{
//    for (int j = i + 1; j < size + 1; j++)
//    {
//        string substrings = name.Substring(i, j - i);
//        Console.WriteLine(substrings);
//    }
//}