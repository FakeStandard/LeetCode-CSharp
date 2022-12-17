using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Solution._0037.Sudoku_solver
{
    public class _0037_Sudoku_solver
    {
        public char[][] SolveSudoku(char[][] board)
        {
            Stack<Grid> stack = new Stack<Grid>();

            int x = 0;
            int y = 0;
            char c = '1';

            while (x < 9 && y < 9)
            {
                if (board[x][y] == '.')
                {
                    bool b = false;

                    for (char i = c; i <= '9'; i++)
                    {
                        b = checkChar(board, x, y, i);

                        if (b)
                        {
                            board[x][y] = i;
                            stack.Push(new Grid { x = x, y = y, c = i });
                            y++;
                            c = '1';
                            break;
                        }
                    }

                    // backtracking
                    if (!b)
                    {
                        Grid g = stack.Pop();
                        x = g.x;
                        y = g.y;
                        c = ++g.c; // check from the next
                        board[x][y] = '.';
                    }
                }
                else y++;

                if (y >= 9)
                {
                    y = 0;
                    x++;
                }
            }

            return board;
        }

        private bool checkChar(char[][] board, int x, int y, int c)
        {
            // check row
            for (int i = 0; i < 9; i++)
                if (board[x][i] == c)
                    return false;

            // check column
            for (int i = 0; i < 9; i++)
                if (board[i][y] == c)
                    return false;

            // check box
            int row = (x / 3) * 3;
            int col = (y / 3) * 3;

            for (int i = row; i < row + 3; i++)
                for (int j = col; j < col + 3; j++)
                    if (board[i][j] == c)
                        return false;

            return true;
        }

        private class Grid
        {
            public int x;
            public int y;
            public char c;
        }
    }
}
