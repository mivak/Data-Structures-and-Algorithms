namespace FindTheMajorantOfAnArray
{
    using System;
    using System.Collections.Generic;

    public class FindTheMajorantOfAnArray
    {
        public static void Main()
        {
            // The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
            // Write a program to find the majorant of given array (if exists). Example:
            // {2, 2, 3, 3, 2, 3, 4, 3, 3, 3} -> 3
            Console.Write("Please enter how many numbers you want to enter: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Please enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bool doesMajorantExist = CheckIfTheMajorantExists(numbers);

            if (doesMajorantExist)
            {
                int majorant = FindMajorant(numbers);
                Console.WriteLine("The majorant number is: {0}", majorant);
            }
            else
            {
                Console.WriteLine("The majorant does not exist");
            }
        }

        private static int FindMajorant(int[] numbers)
        {
            int majorant = 0;
            int counter = 0;
            double majorantCounter = (double)numbers.Length / 2 + 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }

                if (counter >= majorantCounter)
                {
                    majorant = numbers[i];
                    return majorant;
                }

                counter = 0;
            }

            throw new ArgumentException("FindMajorant method returned an error");
        }

        private static bool CheckIfTheMajorantExists(int[] numbers)
        {
            int counter = 0;
            double majorantCounter = (double)numbers.Length / 2 + 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }

                if (counter >= majorantCounter)
                {
                    return true;
                }

                counter = 0;
            }

            return false;
        }
    }
}