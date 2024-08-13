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

                if (IsValidBoard(initial))

                    board = initial;

                else

                    throw new ArgumentException("Board contains invalid number. Only numbers between 1-9 are allowed.");

            else

                board = new int[9, 9];

        }

        public int[] GetSection(int section)
        {
            int x = section / 3;
            int y = section % 3;

            return new int[] { x, y };
        }

        public bool IsValidBoard(int[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int value = board[row, col];

                    if (value < 1 || value > 9)

                        return false;

                }

            }
            return true;
        }

        public void CheckCell(int row, int column, int value)
        {
            if (value < 1 || value > 9)

                throw new ArgumentException("Only values between 1-9 are allowed");

            board[row, column] = value;

        }
    }

}