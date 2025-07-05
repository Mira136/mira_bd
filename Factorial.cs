// Importing System namespace to use Console class
using System;

// Declaring a namespace for this program
namespace mira_bd
{
    // Declaring a class named for this program
    class Factorial
    {
        // Main method
        static void Main(string[] args)
        {
            // Declaring integer variables: 'n' for input number, 'fact' initialized to 1 for storing factorial
            int n, fact = 1;

            // Prompt user to enter a number.
            Console.WriteLine("Enter Number : ");

            // Read input from user as a string and store in 'str'
            string str = Console.ReadLine();

            // Convert the input string to an integer and assign to 'n'
            n = Convert.ToInt32(str);

            // Loop from 1 to n to calculate factorial
            for (int i = 1; i <= n; i++)
            {
                // Multiply 'fact' by 'i' in each iteration
                fact = fact * i;
            }

            // Output the result using formatted string
            Console.WriteLine("Factorial : {0}", fact);

        // Wait for user to press any key before closing the console window
        Console.Read();

        }
    }
}