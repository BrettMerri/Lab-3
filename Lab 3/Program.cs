using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Change color of console text to Cyan
            while (true) //Infinite loop
            {
                Console.Clear();
                Console.WriteLine("Learn your squares and cubes!\n");
                Console.Write("Enter an integer: ");

                string input = Console.ReadLine(); //Prompts user for integer input

                int inputNumber;
                if (!int.TryParse(input, out inputNumber)) //Validating user input to ensure it is an integer
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Input not a number");
                    return;
                }

                Console.WriteLine("\nNumber\t\tSquared\t\tCubed"); //Creating a table header in the console using tabs
                Console.WriteLine("=======\t\t=======\t\t======");

                for (int i = 1; i<=inputNumber; i++) //Creates the numbers in the table
                {
                    double squared = Math.Pow(i, 2);
                    double cubed = Math.Pow(i, 3);
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", i, squared, cubed);
                }

                Console.Write("\nContinue? (y/n): "); //Prompts user if they want to continue
                string continueInput = Console.ReadLine().ToLower();

                if (continueInput == "y")
                {
                    continue;
                }
                else if (continueInput == "n")
                {
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Invalid input!");
                    return;
                }
            }
        }
    }
}
