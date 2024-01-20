//using System;

//class Program
//{
//    static void Main()
//    {
//        // Declare and initialize an array with one missing number
//        int[] numbers = { 1, 2, 4, 5, 6 };

//        // Define the range (1 to n) and find n
//        int n = numbers.Length + 1;

//        // Calculate the expected sum
//        int expectedSum = (n * (n + 1)) / 2;

//        // Calculate the actual sum of the elements in the array
//        int actualSum = 0;
//        foreach (int num in numbers)
//        {
//            actualSum += num;
//        }

//        // Calculate the missing number
//        int missingNumber = expectedSum - actualSum;

//        // Print the missing number
//        Console.WriteLine("The missing number in the array is: " + missingNumber);
//    }
//}







//using System;

//class Program
//{
//    static void Main()
//    {
//        // Declare and initialize an array
//        int[] numbers = { 5, 3, 1, 4, 2, 5, 1 };

//        // Create a variable to track if duplicates are found
//        bool hasDuplicates = false;

//        // Iterate through the array to check for duplicates
//        for (int i = 0; i < numbers.Length - 1; i++)
//        {
//            for (int j = i + 1; j < numbers.Length; j++)
//            {
//                if (numbers[i] == numbers[j])
//                {
//                    hasDuplicates = true;
//                    break; // Exit the loop as soon as a duplicate is found
//                }
//            }
//            if (hasDuplicates)
//                break; // Exit the outer loop as well
//        }

//        if (hasDuplicates)
//        {
//            Console.WriteLine("The array contains duplicate numbers.");
//        }
//        else
//        {
//            Console.WriteLine("The array does not contain any duplicate numbers.");
//        }
//    }
//}












//using System;

//class Program
//{
//    static void Main()
//    {
//        // Declare and initialize an array with zeros
//        int[] array = { 0, 3, 0, 2, 0, 1, 0, 4 };

//        // Define two pointers
//        int left = 0; // Points to the current element being processed
//        int right = array.Length - 1; // Points to the last position in the array

//        while (left < right)
//        {
//            // Find the first non-zero element from the left
//            while (left < right && array[left] != 0)
//            {
//                left++;
//            }

//            // Find the first zero from the right
//            while (left < right && array[right] == 0)
//            {
//                right--;
//            }

//            // Swap the zero from the left with the non-zero element from the right
//            if (left < right)
//            {
//                int temp = array[left];
//                array[left] = array[right];
//                array[right] = temp;
//                left++;
//                right--;
//            }
//        }

//        // Print the array with zeros moved to the end
//        Console.WriteLine("Array with zeros moved to the end:");
//        foreach (int element in array)
//        {
//            Console.Write(element + " ");
//        }
//    }
//}














//using System;

//class Program
//{
//    static void Main()
//    {
//        // Declare and initialize a string array
//        string[] stringArray = { "apple", "banana", "cherry", "date", "fig" };

//        // Target string to search for
//        string target = "cherry";

//        // Variable to store the position of the target string
//        int position = -1;  // Initialize to -1 to indicate not found

//        // Iterate through the array to search for the target string
//        for (int i = 0; i < stringArray.Length; i++)
//        {
//            if (stringArray[i] == target)
//            {
//                position = i;  // Set the position to the index where the target was found
//                break;         // Exit the loop once the target is found
//            }
//        }

//        if (position != -1)
//        {
//            Console.WriteLine($"The target string '{target}' was found at position {position} in the array.");
//        }
//        else
//        {
//            Console.WriteLine($"The target string '{target}' was not found in the array.");
//        }
//    }
//}










//using System;

//class Program
//{
//    static void Main()
//    {
//        // Define two matrices as two-dimensional arrays
//        int[,] matrixA = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        int[,] matrixB = {
//            {9, 8, 7},
//            {6, 5, 4},
//            {3, 2, 1}
//        };

//        // Calculate the subtraction of the two matrices
//        int[,] result = SubtractMatrices(matrixA, matrixB);

//        // Display the result matrix
//        Console.WriteLine("Matrix A:");
//        PrintMatrix(matrixA);
//        Console.WriteLine("Matrix B:");
//        PrintMatrix(matrixB);
//        Console.WriteLine("Result of Matrix Subtraction:");
//        PrintMatrix(result);
//    }

//    static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
//    {
//        int rows = matrixA.GetLength(0);
//        int cols = matrixA.GetLength(1);

//        if (rows != matrixB.GetLength(0) || cols != matrixB.GetLength(1))
//        {
//            throw new ArgumentException("Matrices must have the same dimensions for subtraction.");
//        }

//        int[,] result = new int[rows, cols];

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                result[i, j] = matrixA[i, j] - matrixB[i, j];
//            }
//        }

//        return result;
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}















//using System;

//class Program
//{
//    static void Main()
//    {
//        // Declare and initialize an array of numbers
//        int[] numbers = { 2, 4, 5, 7, 10, 11, 13 };

//        int sumOfPrimes = 0;

//        foreach (int number in numbers)
//        {
//            if (number > 1 && IsPrime(number))
//            {
//                sumOfPrimes += number;
//            }
//        }

//        Console.WriteLine("Array of numbers: " + string.Join(", ", numbers));
//        Console.WriteLine("Sum of prime numbers in the array: " + sumOfPrimes);
//    }

//    static bool IsPrime(int number)
//    {
//        if (number <= 1)
//            return false;

//        if (number <= 3)
//            return true;

//        if (number % 2 == 0 || number % 3 == 0)
//            return false;

//        for (int i = 5; i * i <= number; i += 6)
//        {
//            if (number % i == 0 || number % (i + 2) == 0)
//                return false;
//        }

//        return true;
//    }
//}
















//using System;

//class Program
//{
//    static void Main()
//    {
//        // Declare and initialize an array
//        int[] numbers = { 5, 3, 1, 4, 2, 6, 0 };

//        int smallest = int.MaxValue; // Initialize to a large value
//        int secondSmallest = int.MaxValue; // Initialize to a large value

//        // Iterate through the array to find the smallest and second smallest elements
//        foreach (int num in numbers)
//        {
//            if (num < smallest)
//            {
//                secondSmallest = smallest;
//                smallest = num;
//            }
//            else if (num < secondSmallest && num != smallest)
//            {
//                secondSmallest = num;
//            }
//        }

//        if (secondSmallest != int.MaxValue)
//        {
//            Console.WriteLine("The second smallest element in the array is: " + secondSmallest);
//        }
//        else
//        {
//            Console.WriteLine("There is no second smallest element in the array.");
//        }
//    }
//}
