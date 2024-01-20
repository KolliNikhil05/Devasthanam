namespace program
{
    internal class lowerUpper
    {
        public void lower_Upper()
        {
            char a;
            int i;
            Console.WriteLine("Enter the Character : ");
            a = Convert.ToChar(Console.ReadLine());
            //i = (int)a;
            if (a >= 65 && a <= 90)
            {

                Console.WriteLine("The Character is : {0}", char.ToLower(a));

            }
            else if (a >= 97 && a <= 122)
            {
                Console.WriteLine("The Character is : {0}", char.ToUpper(a));
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }
    }
}
