public class Sudoku
{
    // add all classes and methods in this sudoku game class

    class SudokuBoard
    {
        private int[,] board = new int[9, 9];

        public SudokuBoard(int[,]? initial = null)
        {
            // Initialize the board or load a puzzle

            if (initial != null && initial.GetLength(0) == 9 && initial.GetLength(1) == 9)

                board = initial;

            else

                board = new int[9, 9];
        }

        public int[] GetSection(int section)
        {
            int x = section / 3;
            int y = section % 3;

            return new int[] {x, y};
        }
        
        public void CheckCell(int row, int column, int value)
        {
            if (value < 1 || value > 9)
            {
                throw new ArgumentException("Only values between 1-9 are allowed");
            }
            board[row, column] = value;

        }
    }
}