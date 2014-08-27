namespace RemoveNumbersThatOccurOddNumberOfTimes
{
    using System;
    using System.Collections.Generic;

    public class RemoveNumbersThatOccurOddNumberOfTimes
    {
        public static void Main()
        {
            // Write a program that removes from a given sequence all numbers
            // that occur odd number of times. Example:
            // {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}
            Console.WriteLine("Please enter a sequence of integer numbers and an empty line to finish");

            List<int> numbers = AddNumbersFromConsole();

            List<int> searchedNumbers = RemoveNumbersOccuringOddNumberOfTimes(numbers);

            Console.WriteLine(string.Join(", ", searchedNumbers));
        }
 
        private static List<int> RemoveNumbersOccuringOddNumberOfTimes(List<int> numbers)
        {
            List<int> searchedNumbers = new List<int>();
            List<int> removedNumbers = new List<int>();
            int counter = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }

                if (counter % 2 == 0)
                {
                    removedNumbers.Add(numbers[i]);
                }
                else
                {
                    if (!(removedNumbers.Contains(numbers[i])))
                    {
                        searchedNumbers.Add(numbers[i]);
                    }
                }

                counter = 1;
            }

            return searchedNumbers;
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