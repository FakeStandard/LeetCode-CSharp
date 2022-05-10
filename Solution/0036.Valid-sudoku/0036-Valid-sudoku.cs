using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0036.Valid_sudoku
{
    public class _0036_Valid_sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            // first solution
            /*
            // 針對行.列.方框檢查
            HashSet<char> row = new HashSet<char>();
            HashSet<char> col = new HashSet<char>();
            HashSet<char> box = new HashSet<char>();

            // checked row & col
            // row
            for (int i = 0; i < 9; i++)
            {
                row.Clear();
                col.Clear();

                // col
                for (int j = 0; j < 9; j++)
                {
                    // if the element equals '.' and the element is already present, it return false
                    if (board[i][j] != '.' && !row.Add(board[i][j])) return false;
                    if (board[j][i] != '.' && !col.Add(board[j][i])) return false;
                }
            }

            int x = 0;
            int y = 0;

            // execute nine times, checked the box
            for (int k = 0; k < 9; k++)
            {
                box.Clear();

                // 3x3 box
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // k=0, i,j = 0,0 0,1 0,2 1,0 1,1 1,2 2,0 2,1 2,2

                        // k=0, x,y = 0,0 0,1 0,2 1,0 1,1 1,2 2,0 2,1 2,2
                        // k=1, x,y = 0,3 0,4 0,5 1,3 1,4 1,5 2,3 2,4 2,5
                        // k=2, x,y = 0,6 0,7 0,8 1,6 1,7 1,8 2,6 2,7 2,8

                        // k=3, x,y = 3,0 3,1 3,2 4,0 4,1 4,2 5,0 5,1 5,2
                        // k=4, x,y = 3,3 3,4 3,5 4,3 4,4 4,5 5,3 5,4 5,5
                        // k=5, x,y = 3,6 3,7 3,8 4,6 4,7 4,8 5,6 5,7 5,8

                        // k=6, x,y = 6,0 6,1 6,2 7,0 7,1 7,2 8,0 8,1 8,2
                        // k=7, x,y = 6,3 6,4 6,5 7,3 7,4 7,5 8,3 8,4 8,5
                        // k=8, x,y = 6,6 6,7 6,8 7,6 7,7 7,8 8,6 8,7 8,8

                        x = (k / 3) * 3 + i;
                        y = (k % 3) * 3 + j;

                        if (board[x][y] != '.' && !box.Add(board[x][y])) return false;
                    }
                }
            }

            return true;
            */

            // Improved solution
            HashSet<char> row = new HashSet<char>();
            HashSet<char> col = new HashSet<char>();
            HashSet<char> box = new HashSet<char>();

            int x = 0;
            int y = 0;

            // checked row & col & the box
            for (int i = 0; i < 9; i++)
            {
                row.Clear();
                col.Clear();
                box.Clear();

                for (int j = 0; j < 9; j++)
                {
                    // if the element equals '.' and the element is already present, it return false

                    // row
                    if (board[i][j] != '.' && !row.Add(board[i][j])) return false;

                    // col
                    if (board[j][i] != '.' && !col.Add(board[j][i])) return false;

                    // i,j = 0,0 0,1 0,2 0,3 0,4 0,5 0,6 0,7 0,8
                    // i,j = 1,0 1,1 1,2 1,3 1,4 1,5 1,6 1,7 1,8
                    // ...
                    //* i,j = 5,0 5,1 5,2 5,3 5,4 5,5 5,6 5,7 5,8

                    // box
                    // x,y = 0,0 0,1 0,2 1,0 1,1 1,2 2,0 2,1 2,2
                    // x,y = 0,3 0,4 0,5 1,3 1,4 1,5 2,3 2,4 2,5
                    // x,y = 0,6 0,7 0,8 1,6 1,7 1,8 2,6 2,7 2,8

                    // x,y = 3,0 3,1 3,2 4,0 4,1 4,2 5,0 5,1 5,2
                    // x,y = 3,3 3,4 3,5 4,3 4,4 4,5 5,3 5,4 5,5
                    //* x,y = 3,6 3,7 3,8 4,6 4,7 4,8 5,6 5,7 5,8

                    // x,y = 6,0 6,1 6,2 7,0 7,1 7,2 8,0 8,1 8,2
                    // x,y = 6,3 6,4 6,5 7,3 7,4 7,5 8,3 8,4 8,5
                    // x,y = 6,6 6,7 6,8 7,6 7,7 7,8 8,6 8,7 8,8

                    x = (i / 3) * 3 + j / 3;
                    y = (i % 3) * 3 + (j % 3);

                    if (board[x][y] != '.' && !box.Add(board[x][y])) return false;
                }
            }

            return true;
        }
    }
}
