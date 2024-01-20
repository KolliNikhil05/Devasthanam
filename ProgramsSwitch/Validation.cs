using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsSwitch
{
    internal class Validation
    {
        public void OTP()
        {
            Console.Write("Please Enter a Pin Number: ");
            string pin = Console.ReadLine();
            bool pinValid = pin.Length == 4 || pin.Length == 6;
            if (pinValid)
            {
                for (int i = 0; i < pin.Length; i++)
                {
                    if (!char.IsDigit(pin[i]))
                    {
                        pinValid = false;
                        break;
                    }
                }
            }
            if (pinValid)
            {
                Console.WriteLine("Valid Pin!");
            }
            else
            {
                Console.WriteLine("Invalid Pin!");
            }
        }

    }
}



