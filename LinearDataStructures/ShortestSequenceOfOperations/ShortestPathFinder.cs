namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    
    public class ShortestPathFinder
    {
        private readonly Queue<Tree<int>> holder = new Queue<Tree<int>>();
        private readonly List<Tree<int>> results = new List<Tree<int>>();
        private readonly List<string> pathsWithoutDublicates = new List<string>();

        public ShortestPathFinder(int start, int stop)
        {
            Tree<int> root = new Tree<int>(start);
            this.CreateTree(start, stop, root, this.holder, -1, this.results);
        }

        public void PrintShortestPaths()
        {
            this.ProcessPaths();
            foreach (var path in this.pathsWithoutDublicates)
            {
                Console.WriteLine(path);
                Console.WriteLine();
            }
        }

        private void CreateTree(int start, int stop, Tree<int> currentNode, Queue<Tree<int>> holder, int treeLevelOfStop, List<Tree<int>> results)
        {
            if (treeLevelOfStop == -1 || currentNode.NodeTreeLevel < treeLevelOfStop)
            {
                Tree<int> firstChildToAdd = new Tree<int>(currentNode.Value * 2);
                Tree<int> secondChildToAdd = new Tree<int>(currentNode.Value + 2);
                Tree<int> thirdChildToAdd = new Tree<int>(currentNode.Value + 1);

                if (firstChildToAdd.Value == stop || secondChildToAdd.Value == stop || thirdChildToAdd.Value == stop)
                {
                    treeLevelOfStop = currentNode.NodeTreeLevel + 1;
                }

                if (currentNode.Value > 0 && firstChildToAdd.Value > start && firstChildToAdd.Value <= stop)
                {
                    currentNode.AddChild(firstChildToAdd);
                }

                if (secondChildToAdd.Value > start && secondChildToAdd.Value <= stop)
                {
                    currentNode.AddChild(secondChildToAdd);
                }

                if (thirdChildToAdd.Value > start && thirdChildToAdd.Value <= stop)
                {
                    currentNode.AddChild(thirdChildToAdd);
                }

                for (int i = 0; i < currentNode.CountChildren(); i++)
                {
                    Tree<int> child = currentNode.GetChild(i);
                    if (child.Value == stop)
                    {
                        results.Add(child);
                    }

                    holder.Enqueue(child);
                }

                currentNode = holder.Dequeue();

                this.CreateTree(start, stop, currentNode, holder, treeLevelOfStop, results);
            }
        }

        private void ProcessPaths()
        {
            for (int i = 0; i < this.results.Count; i++)
            {
                Tree<int> result = this.results[i];
                Stack<int> path = new Stack<int>();
                while (result != null)
                {
                    path.Push(result.Value);
                    result = result.Parent;
                }

                string finalPath = string.Join(" -> ", path);
                if (!this.pathsWithoutDublicates.Contains(finalPath))
                {
                    this.pathsWithoutDublicates.Add(finalPath);
                }
            }
        }
    }
}