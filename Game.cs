using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        private string[,] board;

        public Game()
        {
            this.board = new string[3, 3]
            {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" }
            };
        }
        private int CheckBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                string firstEntry = board[i, i];
                if (!firstEntry.Equals("X") && !firstEntry.Equals("O"))
                {
                    continue;
                }
                int horiznotalCount = 0, verticalCount = 0, mainDiagonalCount = 0, sideDiagonalCount = 0;
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j].Equals(firstEntry))
                    {
                        horiznotalCount++;
                    }
                    if (board[j, i].Equals(firstEntry))
                    {
                        verticalCount++;
                    }
                    if (i == 1 && board[j, j].Equals(firstEntry))
                    {
                        mainDiagonalCount++;

                    }
                    if (i == 1 && board[j, 2 - j].Equals(firstEntry))
                    {
                        sideDiagonalCount++;
                    }
                }
                if (horiznotalCount == 3 || verticalCount == 3 || mainDiagonalCount == 3 || sideDiagonalCount == 3)
                {
                    if (firstEntry.Equals("X"))
                        return 1;
                    else
                        return 2;
                }

            }
            return 0;
        }
        public void DrawBoard()
        {
            for(int i = 0; i < 3*3+2; i++)
            {
                for(int j = 0; j < 3*3+2; j++) 
                {
                    if (i % 4 == 1 && j % 4 == 1)
                    {
                        Console.Write(board[i / 4, j / 4]);
                    }
                    else if( (j+1) % 4 == 0)
                    {
                        Console.Write("|");
                    }
                    else if( (i+1) % 4 == 0)
                    {
                        Console.Write("\u2014");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

    }
}
