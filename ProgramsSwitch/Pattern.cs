namespace ProgramsSwitch
{
    internal class Pattern
    {
        public void printPattern()
        {
            Console.Write("Enter a Number: ");
            int Inputnumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Inputnumber; i++)
            {
                for (int space = 1; space <= Inputnumber - i; space++)
                {
                    Console.Write("  ");
                }
                for (char character = 'A'; character <= 'A' + i - 1; character++)
                {
                    Console.Write(character);
                }
                for (int number = 1; number <= i; number++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}

 /*
   int i = 1 
 sapce = 1 to 4-1 =3
 3 sapces

char 
 65 <= 65+i-1
 65<=65+1-1 
 65<=65 so print A

next cycle
 65 <= 65+2-1
 65<=66
 A prints
 char ++ = 66 
66<=65+2-1
 so b prints
 char++ 67
 67 !<= 65+2-1
 so breaks
 
  */