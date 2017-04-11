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
            while (true)
            {
                Console.WriteLine("Learn your squares and cubes!\n");
                Console.Write("Enter an integer: ");

                string input = Console.ReadLine();

                int inputNumber;
                if (!int.TryParse(input, out inputNumber))
                {
                    Console.WriteLine("Input not a number");
                    return;
                }

                Console.WriteLine("\nNumber\tSquared\tCubed");
                Console.WriteLine("=======\t=======\t======");
                Console.WriteLine(inputNumber);

                Console.Write("Continue? (y/n): ");
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
                    Console.WriteLine("Invalid input");
                    return;
                }
            }
        }
    }
}
