namespace FindLongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;

    public class FindLongestSubsequenceOfEqualNumbers
    {
        public static void Main()
        {
            // Write a method that finds the longest subsequence of equal numbers in a given List<int>
            // and returns the result as a new List<int>.
            // Write a program to test whether the method works correctly.

            Console.WriteLine("Please enter a sequence of integer numbers and an empty line to finish");

            List<int> numbers = AddNumbersFromConsole();

            List<int> equals = FindLongestSubsequenceOfEquals(numbers);

            Console.WriteLine(string.Join(", ", equals));
        }

        private static List<int> FindLongestSubsequenceOfEquals(List<int> numbers)
        {
            List<int> equals = new List<int>();
            int counter = 1;
            int max = 0;
            int repeatingNumber = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        if (counter > max)
                        {
                            max = counter;
                            repeatingNumber = numbers[j];
                        }
                    }
                }

                counter = 1;
            }

            for (int i = 0; i < max; i++)
            {
                equals.Add(repeatingNumber);
            }

            return equals;
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