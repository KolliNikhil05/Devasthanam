namespace ProgramsSwitch
{
    internal class RandomNumbers
    {
        public void RandomGenerate()
        {
            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next();
            Console.WriteLine("Random Number is :" +  randomNumber);
        }
    }
}
