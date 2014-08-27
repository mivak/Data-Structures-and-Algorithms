namespace CalculateSumAndAverage
{
    using System;
    using System.Collections.Generic;

    public class CalculateSumAndAverage
    {
        public static void Main()
        {
            // Write a program that reads from the console a sequence of positive integer numbers.
            // The sequence ends when an empty line is entered. Calculate and print the sum and average
            // of the elements of the sequence. Keep the sequence in List<int>.

            Console.WriteLine("Please enter a sequence of positive integer numbers and an empty line to finish");

            List<int> numbers = AddNumbersFromConsole();

            int sum = CalculateSum(numbers);

            double average = (double)sum / (double)numbers.Count;

            Console.WriteLine("Sum: {0}\nAverage: {1:F2}", sum, average);
        }

        private static int CalculateSum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
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
                    if (number > 0)
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Number should be a positive integer");
                    }
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