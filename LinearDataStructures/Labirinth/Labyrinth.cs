namespace Labirinth
{
    using System;
    using System.Collections.Generic;

    public class Labyrinth
    {
        internal static void FillLabyrinth(string[,] labyrinth, Coordinate startCoordinate)
        {
            Queue<Coordinate> coordinates = new Queue<Coordinate>();
            coordinates.Enqueue(startCoordinate);
            BreadthFirstSearch(coordinates, labyrinth);
            FillUnreachableCells(labyrinth);
        }

        internal static void PrintLabyrinth(string[,] labyrinth)
        {
            int rows = labyrinth.GetLength(0);
            int cols = labyrinth.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0,4}", labyrinth[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void BreadthFirstSearch(Queue<Coordinate> coordinates, string[,] labyrinth)
        {
            while (coordinates.Count != 0)
            {
                Coordinate currentCoordinate = coordinates.Dequeue();
                int x = currentCoordinate.X;
                int y = currentCoordinate.Y;
                int value = currentCoordinate.Value + 1;

                if (x + 1 < labyrinth.GetLength(0) && labyrinth[x + 1, y] == "0")
                {
                    labyrinth[x + 1, y] = value.ToString();
                    coordinates.Enqueue(new Coordinate(x + 1, y, value));
                }

                if (x - 1 >= 0 && labyrinth[x - 1, y] == "0")
                {
                    labyrinth[x - 1, y] = value.ToString();
                    coordinates.Enqueue(new Coordinate(x - 1, y, value));
                }

                if (y + 1 < labyrinth.GetLength(1) && labyrinth[x, y + 1] == "0")
                {
                    labyrinth[x, y + 1] = value.ToString();
                    coordinates.Enqueue(new Coordinate(x, y + 1, value));
                }

                if (y - 1 >= 0 && labyrinth[x, y - 1] == "0")
                {
                    labyrinth[x, y - 1] = value.ToString();
                    coordinates.Enqueue(new Coordinate(x, y - 1, value));
                }
            }
        }

        private static void FillUnreachableCells(string[,] labyrinth)
        {
            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    if (labyrinth[row, col] == "0")
                    {
                        labyrinth[row, col] = "u";
                    }
                }
            }
        }
    }
}