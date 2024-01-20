

namespace program
{
    internal class gradeDescription
    {
        public void DescriptionOfGrade()
        {
            char grade;
            Console.WriteLine("Enter the Grade in Upper Case: \n");
            grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'S':
                    Console.WriteLine(" SUPER");
                    break;
                case 'A':
                    Console.WriteLine(" VERY GOOD");
                    break;
                case 'B':
                    Console.WriteLine(" FAIR");
                    break;
                case 'C':
                    Console.WriteLine(" AVERAGE");
                    break;
                case 'F':
                    Console.WriteLine(" FAIL");
                    break;
                default:
                    Console.WriteLine("ERROR IN GRADE \n");
                    break;
                   
            }
        }
            
    }
}
