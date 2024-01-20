using Newtonsoft.Json;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter hobbies (comma-separated): ");
            string[] hobbies = Console.ReadLine().Split(',');
            Person person = new Person(name, phone, id, hobbies);
            people.Add(person);
            string json = JsonConvert.SerializeObject(people, Formatting.Indented);
            string filePath = @"C:\Users\K.Nikhil\Downloads\asd.txt";
            File.WriteAllText(filePath, json);
            Console.WriteLine($"\nJSON data saved to {filePath}");
        }
    }
}
    class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Id { get; set; }
        public string[] Hobbies { get; set; }
        public Person(string name, string phone, int id, string[] hobbies)
        {
            Name = name;
            Phone = phone;
            Id = id;
            Hobbies = hobbies;
        }
    }



























//CheckEvenOdd p = new CheckEvenOdd();
//p.checkNumberEvenOdd();

//oddInRange o = new oddInRange();
//o.oddRange();

//checkPositive c = new checkPositive();
//c.checkPositiveNum();

//largestNumber l = new largestNumber();
//l.largestNum();

//swap s = new swap();
//s.swapNum();

//dividedTwo d = new dividedTwo();
//d.dividedByTwo();

//sumMultiples multiples = new sumMultiples();
//multiples.sumOfMultiples();

//multiplesSiventeen m = new multiplesSiventeen();
//m.multiplesOfSiventeen();

//sumDigits sum = new sumDigits();
//sum.sumOfDigits();

//Console.WriteLine("enter number:");
//int num = Convert.ToInt32(Console.ReadLine());
//int sum = sumRecursion.sumByRecursion(num);
//Console.WriteLine("sum is :" + sum);

//reverse r = new reverse();
//r.reverseNum();

//palindrome pa = new palindrome();
//pa.checkPalindrome();

//binarySum bi = new binarySum();
//bi.sumOfBinary();

//binarymul asd = new binarymul();
//asd.multiplyOfBinary();

//binaryMultiply bm = new binaryMultiply();
//bm.multiplyOfBinary();

//operations operations = new operations();
//operations.performOperations();

//exponentsmul ex = new exponentsmul();
//ex.exponents();

//exponentsdiv des = new exponentsdiv();
//des.expdivision();

//binaryInt bee = new binaryInt();
//bee.nem();

//table t = new table();
//t.multiplyTable();

//gradeDescription gd = new gradeDescription();
//gd.DescriptionOfGrade();

//lowerUpper lu = new lowerUpper();
//lu.lower_Upper();

//heightCategorize hg = new heightCategorize();
//hg.heights();