namespace FindHowManyTimesEachNumberOccurs
{
    using System;
    using System.Collections.Generic;

    public class FindHowManyTimesEachNumberOccurs
    {
        public static void Main()
        {
            // Write a program that finds in given array of integers (all belonging to the range [0..1000])
            // how many times each of them occurs.
            // Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
            // 2 -> 2 times
            // 3 -> 4 times
            // 4 -> 3 times

            Console.Write("Please enter how many numbers you want to enter: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Please enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            SortedDictionary<int, int> numbersOccurences = FindOccurences(numbers);
            foreach (var item in numbersOccurences)
            {
                Console.WriteLine(item.Key + " -> " + item.Value + " times");
            }
        }

        private static SortedDictionary<int, int> FindOccurences(int[] numbers)
        {
            SortedDictionary<int, int> numbersOccurence = new SortedDictionary<int, int>();
            int counter = 0;
            int length = numbers.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                if (!(numbersOccurence.ContainsKey(numbers[i])))
                {    
                    numbersOccurence.Add(numbers[i], counter);
                }

                counter = 0;
            }

            return numbersOccurence;
        }
    }
}