namespace Sudoku
{
    public class Game
    {
        // add all classes and methods in this sudoku game class

        class Board
        {
            private int[,] board = new int[9, 9];

            public Board(int[,]? initial = null)
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

            public bool SetCell(int row, int column, int value)
            {
                if (value < 1 || value > 9)

                    return false;
                
                board[row, column] = value;
                return true;

            }
        }

    }

}
