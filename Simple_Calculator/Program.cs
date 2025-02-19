namespace Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="Calculator" />
    /// </summary>
    public class Calculator
    {
        // Method to add two integers

        /// <summary>
        /// The Add
        /// </summary>
        /// <param name="a">The a<see cref="int"/></param>
        /// <param name="b">The b<see cref="int"/></param>
        /// <returns>The <see cref="int"/></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to subtract two integers

        /// <summary>
        /// The Subtract
        /// </summary>
        /// <param name="a">The a<see cref="int"/></param>
        /// <param name="b">The b<see cref="int"/></param>
        /// <returns>The <see cref="int"/></returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method to multiply two integers

        /// <summary>
        /// The Multiply
        /// </summary>
        /// <param name="a">The a<see cref="int"/></param>
        /// <param name="b">The b<see cref="int"/></param>
        /// <returns>The <see cref="int"/></returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method to divide two integers with validation to avoid division by zero

        /// <summary>
        /// The Divide
        /// </summary>
        /// <param name="a">The a<see cref="int"/></param>
        /// <param name="b">The b<see cref="int"/></param>
        /// <returns>The <see cref="int"/></returns>
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

    /// <summary>
    /// Defines the <see cref="Operations" />
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// The Main
        /// </summary>
        public static void Main()
        {
            Calculator cal = new Calculator();
            bool continueCalculation;

            do
            {
                try
                {
                    // Taking user input for numbers
                    Console.WriteLine("Enter the first number:");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the second number:");
                    int b = Convert.ToInt32(Console.ReadLine());

                    // Displaying operation choices
                    Console.WriteLine("Select the operation you want to perform:");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("4. Divide");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    int result = 0;
                    bool validChoice = true;

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
                        default:
                            Console.WriteLine("Invalid Choice. Please select a valid operation.");
                            validChoice = false;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid integer.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                // Asking user if they want to continue
                Console.WriteLine("Do you want to perform another operation? (yes/no)");
                string response = Console.ReadLine().ToLower();
                continueCalculation = response == "yes" || response == "y";

            } while (continueCalculation);

            Console.WriteLine("Thank you for using the calculator!");
        }
    }

}
