namespace ProgramsSwitch
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter select the any of below  Program Number from 1 to 13:");
            //Console.WriteLine("1.Reverse the Case ");
            //Console.WriteLine("2.Find String ");
            //Console.WriteLine("3.Validate OTP ");
            //Console.WriteLine("4.Convert Minutes into Seconds ");
            //Console.WriteLine("5.remove the character at a given position in the string");
            //Console.WriteLine("6.Second Largest Element In Array");
            //Console.WriteLine("7.Missing and Twice In Array");
            //Console.WriteLine("8.Finding Possible Sub Strings");
            //Console.WriteLine("9.generate random numbers");
            //Console.WriteLine("10.addition operations for the given numbers{2,3,4}");
            //Console.WriteLine("11.to print pattern");
            //Console.WriteLine("12.smallest element in Array");

            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    ReverseTheCase objReverse = new ReverseTheCase();
                    objReverse.ReverseCase();

                    break;
                case "2":
                    FindString objFind = new FindString();
                    objFind.NameSearch();
                    break;
                case "3":
                    Validation objValidate = new Validation();
                    objValidate.OTP();
                    break;
                case "4":
                    Convertion objConvert = new Convertion();
                    objConvert.Converting();
                    break;
                case "5":
                    Remove objRemove = new Remove();
                    objRemove.Removing();
                    break;
                case "6":
                    SecondLargestInArray objSecondLargest = new SecondLargestInArray();
                    objSecondLargest.SecondLargest();
                    break;
                case "7":
                    MissingElementInArray objMissing = new MissingElementInArray();
                    objMissing.MissingInArray();
                    break;
                case "8":
                    SubStrings objSubstring = new SubStrings();
                    objSubstring.findingSubString();
                    break;
                case "9":
                    RandomNumbers objRandom = new RandomNumbers();
                    objRandom.RandomGenerate();
                    break;
                case "10":
                    AdditionOperations objAddNumbers = new AdditionOperations();
                    objAddNumbers.AddNumbers();
                    break;
                case "11":
                    Pattern objPattern = new Pattern();
                    objPattern.printPattern();
                    break;
                case "12":
                    SmallestElement objSmallest = new SmallestElement();
                    objSmallest.SmallestInArray();
                    break;
                case "13":
                    Console.WriteLine("Encapsulation");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter from 1 to 13.");
                    break;
            }
        }
    }
}




