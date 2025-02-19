using System;

namespace Calculation
{
    public class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to subtract two integers
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method to multiply two integers
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method to divide two integers with validation to avoid division by zero
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Calculator cal = new Calculator();
            bool continueCalculation;

            do
            {
                // Taking user input for numbers with validation
                int a = GetValidInteger("Enter the first number:");
                int b = GetValidInteger("Enter the second number:");

                // Displaying operation choices
                Console.WriteLine("Select the operation you want to perform:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");

                int choice = GetValidInteger("Enter your choice (1-4):", 1, 4);

                int result = 0;

                // Performing operation based on user choice
                switch (choice)
                {
                    case 1:
                        result = cal.Add(a, b);
                        Console.WriteLine("The sum of two numbers is: " + result);
                        break;
                    case 2:
                        result = cal.Subtract(a, b);
                        Console.WriteLine("The subtraction of two numbers is: " + result);
                        break;
                    case 3:
                        result = cal.Multiply(a, b);
                        Console.WriteLine("The multiplication of two numbers is: " + result);
                        break;
                    case 4:
                        result = cal.Divide(a, b);
                        Console.WriteLine("The division of two numbers is: " + result);
                        break;
                }

                // Asking user if they want to continue
                Console.WriteLine("Do you want to perform another operation? (yes/no)");
                string response = Console.ReadLine().Trim().ToLower();
                continueCalculation = response == "yes" || response == "y";

            } while (continueCalculation);

            Console.WriteLine("Thank you for using the calculator!");
        }

        // Method to get a valid integer from user
        private static int GetValidInteger(string message)
        {
            int number;
            bool isValid;
            do
            {
                Console.WriteLine(message);
                isValid = int.TryParse(Console.ReadLine(), out number);

                if (!isValid)
                {
                    Console.WriteLine("Error: Please enter a valid integer.");
                }

            } while (!isValid);

            return number;
        }

        // Method to get a valid integer within a specific range
        private static int GetValidInteger(string message, int min, int max)
        {
            int number;
            bool isValid;
            do
            {
                Console.WriteLine(message);
                isValid = int.TryParse(Console.ReadLine(), out number) && number >= min && number <= max;

                if (!isValid)
                {
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}.");
                }

            } while (!isValid);

            return number;
        }
    }
}