using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsSwitch
{
    internal class Convertion
    {
        public void Converting()
        {
            Console.WriteLine("Please Enter Minutes to Convert:");
            int Minutes = Convert.ToInt32(Console.ReadLine());
            int Seconds = Minutes * 60;
            Console.WriteLine("The Seconds are : " + Seconds);
        }
    }
}
