namespace LinkedList
{
    using System;

    public class LinkedListMain
    {
        public static void Main()
        {
            // Implement the data structure linked list. Define a class ListItem<T> that has two fields:
            // value (of type T) and NextItem (of type ListItem<T>). Define additionally a class LinkedList<T>
            // with a single field FirstElement (of type ListItem<T>).

            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(1);
            numbers.AddLast(2);
            numbers.AddFirst(3);
            numbers.AddFirst(4);
            numbers.AddLast(5);
            numbers.AddAfter(numbers.FirstElement.NextItem.NextItem.NextItem, 6);
            numbers.AddBefore(numbers.FirstElement.NextItem.NextItem.NextItem, 7);
            numbers.AddBefore(numbers.FirstElement, 0);
            numbers.RemoveFirst();
            numbers.RemoveLast();

            ListItem<int> next = numbers.FirstElement;
            while (next != null)
            {
                Console.WriteLine(next.Value);
                next = next.NextItem;
            }

            Console.WriteLine(numbers.Count);
        }
    }
}