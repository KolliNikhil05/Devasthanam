using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsSwitch
{
    internal class Remove
    {
        public void Removing()
        {
            Console.WriteLine("Please Enter a Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter a Position to Delete:");
            int position = Convert.ToInt32(Console.ReadLine());
            string result = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (i == position)
                {
                    continue;
                }
                result += name[i];
            }

            Console.WriteLine("After deleting"+ position + "becomes : " + result);
        }
         
    }
}


 