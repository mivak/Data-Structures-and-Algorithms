namespace MaximalPath
{
    using System;
    using System.Collections.Generic;

    public class MaximalPath
    {
        static long maxSum = 0;
        static readonly HashSet<Node> usedNodes = new HashSet<Node>();
        
        private static void Dfs(Node node, long currentSum)
        {
            currentSum += node.Value;
            usedNodes.Add(node);

            for (int i = 0; i < node.NumberOfChildren; i++)
            {
                if (usedNodes.Contains(node.GetChild(i)))
                {
                    continue;
                }

                Dfs(node.GetChild(i), currentSum);
            }

            if (node.NumberOfChildren == 1 && currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            for (int i = 0; i < n - 1; i++)
            {
                string connection = Console.ReadLine();
                string[] separatedConnection = connection.Split(new char[] { '(', '<', '-', ')' }, StringSplitOptions.RemoveEmptyEntries);

                int parent = int.Parse(separatedConnection[0]);
                int child = int.Parse(separatedConnection[1]);

                Node parentNode;
                Node childNode;

                if (nodes.ContainsKey(parent))
                {
                    parentNode = nodes[parent];
                }
                else
                {
                    parentNode = new Node(parent);
                    nodes.Add(parent, parentNode);
                }

                if (nodes.ContainsKey(child))
                {
                    childNode = nodes[child];
                }
                else
                {
                    childNode = new Node(child);
                    nodes.Add(child, childNode);
                }

                parentNode.AddChild(childNode);
                childNode.AddChild(parentNode);
            }

            foreach (var node in nodes)
            {
                if (node.Value.NumberOfChildren == 1)
                {
                    usedNodes.Clear();
                    Dfs(node.Value, 0);
                }
            }

            Console.WriteLine(maxSum);
        }
    }

    public class Node
    {
        private readonly int value;
        private readonly List<Node> children;

        public Node(int value)
        {
            this.value = value;
            this.children = new List<Node>();
        }

        public int Value
        {
            get
            {
                return this.value;
            }
        }

        public int NumberOfChildren
        {
            get
            {
                return this.children.Count;
            }
        }

        public void AddChild(Node child)
        {
            children.Add(child);
        }

        public Node GetChild(int index)
        {
            return this.children[index];
        }
    }
}