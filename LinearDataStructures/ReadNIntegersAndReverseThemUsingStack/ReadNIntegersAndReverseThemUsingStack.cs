namespace ReadNIntegersAndReverseThemUsingStack
{
    using System;
    using System.Collections.Generic;

    public class ReadNIntegersAndReverseThemUsingStack
    {
        public static void Main()
        {
            // Write a program that reads N integers from the console and reverses them using a stack.
            // Use the Stack<int> class.

            Stack<int> numbers = new Stack<int>();
            Console.WriteLine("Please enter the value of \"n\" (the number of integers you want to enter)");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter a number: ");
                numbers.Push(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("The reversed numbers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}