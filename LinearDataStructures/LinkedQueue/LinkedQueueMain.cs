namespace LinkedQueue
{
    using System;

    public class LinkedQueueMain
    {
        static void Main()
        {
            // Implement the ADT queue as dynamic linked list. Use generics (LinkedQueue<T>)
            // to allow storing different data types in the queue.

            LinkedQueue<int> queue = new LinkedQueue<int>();

            for (int i = 0; i < 10; i++)
            {
                queue.Push(i);
            }

            Console.WriteLine(queue.Peek());

            int length = queue.Count;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(queue.Pop());
            }

            queue.Push(100);
            Console.WriteLine(queue.Pop());
        }
    }
}