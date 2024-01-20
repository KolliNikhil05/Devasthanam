using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsSwitch
{
    internal class SecondLargestInArray
    {
        public void SecondLargest()
        {
            Console.WriteLine("Enter size of Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] ArrayElements = new int[size];
            Console.WriteLine("Enter Elements");
            for(int i = 0; i < size; i++)
            {
                ArrayElements[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int j= 0;j < size; j++)
            {
                for(int k= 0;k < size; k++)
                {
                    if (ArrayElements[j] < ArrayElements[k])
                    {
                        int temp = ArrayElements[j];
                        ArrayElements[j] = ArrayElements[k];
                        ArrayElements[k] = temp;
                    }
                }
            }
            Console.WriteLine("Second Largest Element in Array is: " + ArrayElements[size - 2]);
        }
    }
}



























/*public void missing_and_repeatedValue()
{
    int[] array1 = { 1, 2, 8, 4, 6, 5, 7, 8 };
    Array.Sort(array1);
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] == array1[i + 1])
        {
            Console.WriteLine("repeated " + array1[i]);
            break;
        }
    };
    var a = array1[0];
    for (int i = 0; i < array1.Length; i++)
    {
        if (!(array1[i] == a))
        {
            Console.WriteLine("Mising " + a);
            break;
        }
        a = a + 1;

    }
}
*/
