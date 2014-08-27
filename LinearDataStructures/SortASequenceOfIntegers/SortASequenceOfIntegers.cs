namespace SortASequenceOfIntegers
{
    using System;
    using System.Collections.Generic;

    public class SortASequenceOfIntegers
    {
        public static void Main()
        {
            // Write a program that reads a sequence of integers (List<int>) ending with an empty line
            // and sorts them in an increasing order.

            Console.WriteLine("Please enter a sequence of integer numbers and an empty line to finish");

            List<int> numbers = AddNumbersFromConsole();

            List<int> sortedNumbers = Sort(numbers);

            Console.WriteLine(string.Join(", ", sortedNumbers));           
        }

        private static List<int> Sort(List<int> numbers)
        {
            List<int> sortedNumbers = numbers;
            sortedNumbers.Sort((firstNumber, secondNumber) => firstNumber.CompareTo(secondNumber));
            return sortedNumbers;
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