namespace ShortestSequenceOfOperations
{
    using System;

    public class ShortestSequenceOfOperationsMain
    {
        static void Main()
        {
            // We are given numbers N and M and the following operations:
            // N = N+1
            // N = N+2
            // N = N*2
            // Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M. Hint: use a queue.
            // Example: N = 5, M = 16
            // Sequence: 5 -> 7 -> 8 -> 16

            ShortestPathFinder pathFinder = new ShortestPathFinder(5, 16);
            pathFinder.PrintShortestPaths();
            Console.WriteLine();
            pathFinder = new ShortestPathFinder(0, 26);
            pathFinder.PrintShortestPaths();
            Console.WriteLine();
            pathFinder = new ShortestPathFinder(-5, 26);
            pathFinder.PrintShortestPaths();
            Console.WriteLine();
            pathFinder = new ShortestPathFinder(-8, 26);
            pathFinder.PrintShortestPaths();
            Console.WriteLine();
            pathFinder = new ShortestPathFinder(-13, 0);
            pathFinder.PrintShortestPaths();
        }
    }
}