/*
 * Author: Ethen Gonzalez
 * Course: COMP-003A
 * Purpose: Repicate Methods & XML Comments Output
 */

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call PrintSeparator method and pass "Triangle" as parameter
            PrintSeparator("      Triangle Section");

            // Request a single character input from the user
            Console.Write("Enter a single character: ");
            char inputCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Request a positive whole number input from the user
            Console.Write("Enter a positive whole number: ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Call IsoscelesTriangleBuilder method with user inputs
            IsoscelesTriangleBuilder(inputCharacter, size);

            // Call PrintSeparator method again and pass "Favorite Characters" as parameter
            PrintSeparator("        Favorite Characters Section");

            // Call CharacterInfo method at least 5 times with favorite characters and birth years
            CharacterInfo("Spider-Man", 1962);
            CharacterInfo("Batman", 1939);
            CharacterInfo("Walter White", 1958);
            CharacterInfo("Spongebob Squarepants", 1986);
            CharacterInfo("Naruto Uzumaki", 1999);
        }

        /// <summary>
        /// Method to print a separator of 50 asterisks.
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine(new string('*', 50));
        }

        /// <summary>
        /// Method to print a separator with a custom string parameter.
        /// </summary>
        /// <param name="separator">The string to use as the separator.</param>
        static void PrintSeparator(string separator)
        {
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(separator);
            Console.WriteLine(new string('*', 50));
        }

        /// <summary>
        /// Method to build an isosceles triangle using a specified character and size.
        /// </summary>
        /// <param name="inputCharacter">The character to use for building the triangle.</param>
        /// <param name="size">The size of the triangle.</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }

            for (int i = size - 1; i >= 1; i--)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
        }

        /// <summary>
        /// Method to calculate the age based on the provided birth year.
        /// </summary>
        /// <param name="year">The birth year.</param>
        /// <returns>The calculated age.</returns>
        static int AgeCalculator(int year)
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - year;
        }

        /// <summary>
        /// Method to display the name and calculated age of a character.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="birthYear">The birth year or first appearance year of the character.</param>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {age} this year!");
        }
    }
}
