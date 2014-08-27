namespace StackAsAutoResizableArray
{
    using System;

    public class StackAsAutoResizableArray
    {
        public static void Main()
        {
            // Implement the ADT stack as auto-resizable array. Resize the capacity on demand
            // (when no space is available to add / insert a new element).

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Push(30);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}