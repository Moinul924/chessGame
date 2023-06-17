﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess2
{
    public class Board
    {
        public static ChessBoardSquares[,] ChessBoard = new ChessBoardSquares[8,8];

        public Board()
        {
            ChessBoard = new ChessBoardSquares[8, 8]; 
        }

        public static void RemovePiece(int SquarePositionX, int SquarePositionY)
        {
            ChessBoard[SquarePositionX, SquarePositionY].Image = null;
            Console.WriteLine("dgfdsg");
        }

        public static void AddPiece(Image PieceCopied , int SquarePositionX, int SquarePositionY)
        {
            ChessBoard[SquarePositionX,SquarePositionY].Image = PieceCopied;
        }
    }
}
