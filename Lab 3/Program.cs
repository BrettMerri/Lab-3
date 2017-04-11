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
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Learn your squares and cubes!\n");
                Console.Write("Enter an integer: ");

                string input = Console.ReadLine();

                int inputNumber;
                if (!int.TryParse(input, out inputNumber))
                {
                    Console.WriteLine("Input not a number");
                    return;
                }

                Console.WriteLine("\nNumber\t\tSquared\t\tCubed");
                Console.WriteLine("=======\t\t=======\t\t======");
                for (int i = 1; i<=inputNumber; i++)
                {
                    double squared = Math.Pow(i, 2);
                    double cubed = Math.Pow(i, 3);
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", i, squared, cubed);
                }

                Console.Write("\nContinue? (y/n): ");
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
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
        }
    }
}
