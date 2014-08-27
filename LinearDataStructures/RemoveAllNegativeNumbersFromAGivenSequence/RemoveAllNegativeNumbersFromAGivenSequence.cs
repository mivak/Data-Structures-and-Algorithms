namespace RemoveAllNegativeNumbersFromAGivenSequence
{
    using System;
    using System.Collections.Generic;

    public class RemoveAllNegativeNumbersFromAGivenSequence
    {
        public static void Main()
        {
            // Write a program that removes from a given sequence all negative numbers.

            Console.WriteLine("Please enter a sequence of integer numbers and an empty line to finish");

            List<int> numbers = AddNumbersFromConsole();

            List<int> nonNegativeNumbers = RemoveNegativeNumbers(numbers);

            Console.WriteLine(string.Join(", ", nonNegativeNumbers));
        }

        private static List<int> RemoveNegativeNumbers(List<int> numbers)
        {
            List<int> nonNegativeNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number >= 0)
                {
                    nonNegativeNumbers.Add(number);
                }
            }

            return nonNegativeNumbers;
        }

        private static List<int> AddNumbersFromConsole()
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line != string.Empty)
                {
                    int number = int.Parse(line);
                    numbers.Add(number);
                }
                else
                {
                    break;
                }
            }

            return numbers;
        }
    }
}