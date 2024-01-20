using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsSwitch
{
    internal class AdditionOperations
    {
        public void AddNumbers()
        {
            Console.WriteLine("Enter numbers and click on Spacebar After Every Number:");
            string[] inputNumbers = Console.ReadLine().Split(' ');

            if (inputNumbers.Length < 2 || inputNumbers.Length > 4)
            {
                Console.WriteLine("Input must be 2, 3, or 4 numbers");
                return;
            }

            int sum = 0;
            foreach (string number in inputNumbers)
            {
                if (int.TryParse(number, out int parsedNumber))
                {
                    sum += parsedNumber;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
