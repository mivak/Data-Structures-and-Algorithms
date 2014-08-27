namespace ShortestSequenceOfOperations
{
    using System.Collections.Generic;

    public class Tree<T>
    {
        private readonly List<Tree<T>> children;

        public Tree(T value)
        {
            this.Value = value;
            this.children = new List<Tree<T>>();
            this.NodeTreeLevel = 0;
        }

        public T Value { get; set; }

        public Tree<T> Parent { get; set; }

        public int NodeTreeLevel { get; set; }

        public void AddChild(Tree<T> child)
        {
            child.Parent = this;
            child.NodeTreeLevel = this.NodeTreeLevel + 1;
            this.children.Add(child);
        }

        public int CountChildren()
        {
            int count = this.children.Count;
            return count;
        }

        public Tree<T> GetChild(int index)
        {
            return this.children[index];
        }
    }
}