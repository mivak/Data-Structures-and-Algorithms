namespace Labirinth
{
    public class LabyrinthMain
    {
        private static readonly string[,] labyrinth = 
            {
                { "0", "0", "0", "X", "0", "X" },
                { "0", "X", "0", "X", "0", "X" },
                { "0", "*", "X", "0", "X", "0" },
                { "0", "X", "0", "0", "0", "0" },
                { "0", "0", "0", "X", "X", "0" },
                { "0", "0", "0", "X", "0", "X" }
            };

        public static void Main()
        {
            // We are given a labyrinth of size N x N. Some of its cells are empty (0) and some are full (x).
            // We can move from an empty cell to another empty cell if they share common wall.
            // Given a starting position (*) calculate and fill in the array the minimal distance
            // from this position to any other cell in the array. Use "u" for all unreachable cells.

            Coordinate startCoordinate = new Coordinate(2, 1, 0);
            Labyrinth.FillLabyrinth(labyrinth, startCoordinate);
            Labyrinth.PrintLabyrinth(labyrinth);
        }
    }
}