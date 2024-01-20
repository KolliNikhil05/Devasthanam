using System.Text.RegularExpressions;

namespace Program
{
    internal class Pin
    {
        static void Main()
        {
            Console.Clear();

            Console.Write("Enter a PIN code: ");
            string pinCode = Console.ReadLine();

            bool isValid = ValidatePIN(pinCode);

            if (isValid)
            {
                Console.WriteLine("PIN is valid.");
            }
            else
            {
                Console.WriteLine("PIN is not valid.");
            }
        }

        static bool ValidatePIN(string pinCode)
        {
            // Use a regular expression to check if the PIN is 4 or 6 digits only
            Regex regex = new Regex(@"^\d{4}$|^\d{6}$");

            return regex.IsMatch(pinCode);
        }
    }
}
