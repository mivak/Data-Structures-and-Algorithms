namespace PrintFirst50MembersUsingQueue
{
    using System;
    using System.Collections.Generic;

    public class PrintFirst50MembersUsingQueue
    {
        public static void Main()
        {
            // We are given the following sequence:
            // S1 = N;
            // S2 = S1 + 1;
            // S3 = 2*S1 + 1;
            // S4 = S1 + 2;
            // S5 = S2 + 1;
            // S6 = 2*S2 + 1;
            // S7 = S2 + 2;
            // ...
            // Using the Queue<T> class write a program to print its first 50 members for given N.
            // Example: N=2 -> 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

            Console.Write("Please enter the value of \"N\": ");
            int n = int.Parse(Console.ReadLine());
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(n);
            int membersLength = 50;

            for (int i = 0; i < membersLength; i++)
            {
                int current = numbers.Dequeue();
                if (i != membersLength - 1)
                {
                    Console.Write(current + ", ");
                }
                else
                {
                    Console.Write(current + "\n");
                }

                numbers.Enqueue(current + 1);
                numbers.Enqueue(2 * current + 1);
                numbers.Enqueue(current + 2);
            }
        }
    }
}