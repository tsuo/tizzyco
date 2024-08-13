using System;

class Sudoku
{
    // add all classes and methods in this sudoku game class

    class sudokuBoard
    {
        private int[,] board = new int[9, 9];

        public sudokuBoard(int[,] initial = null)
        {
            // Initialize the board or load a puzzle

            if (initial != null && initialBoard.GetLength(0) == 9 && initialBoard.GetLength(1) == 9))

                board = initial;

            else

                board = new int[9, 9];
        }

        public int[] GetSection(int section)
        {
            int sectionIndex;

            int x = section / 3;
            int y = section % 3;

            return [x, y];

        }
    }
}