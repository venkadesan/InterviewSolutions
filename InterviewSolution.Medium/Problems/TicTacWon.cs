using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public enum Piece
    {
        Empty,
        Red,
        Blue
    };
    public class TicTacWon
    {
        // Need to implement efficient algorithm


        #region based on Last Move
        public Piece hasWon(Piece[,] board, int row, int column)
        {
            if (board.GetLength(0) != board.GetLength(1))
                return Piece.Empty;

            Piece peice = board[row, column];
            if (peice == Piece.Empty) return Piece.Empty;

            if (hasRowWon(board, row) || hasColumnWon(board, column))
            {
                return peice;
            }
            if (row == column && HasWonDiagonal(board, 1))
            {
                return peice;
            }

            if (row == (board.GetLength(0) - column - 1) && HasWonDiagonal(board, -1))
            {
                return peice;
            }

            return Piece.Empty;
        }

        private bool hasRowWon(Piece[,] board, int row)
        {
            for (int c = 1; c < board.GetLength(1); c++)
            {
                if (board[row, c] != board[row, 0])
                {
                    return false;
                }
            }
            return true;
        }

        private bool hasColumnWon(Piece[,] board, int column)
        {
            for (int r = 1; r < board.GetLength(0); r++)
            {
                if (board[r, column] != board[0, column])
                {
                    return false;
                }
            }
            return true;
        }

        private bool HasWonDiagonal(Piece[,] board, int direction)
        {
            int row = 0;
            int column = direction == 1 ? 0 : board.GetLength(0) - 1;
            Piece first = board[0, column];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[row, column] != first)
                {
                    return false;
                }
                row++;
                column += direction;
            }
            return true;
        }
        #endregion




    }

}

