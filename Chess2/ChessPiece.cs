﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess2
{
    public class ChessPiece
    {
        public int chessPiece;
        public int chessPieceColour;
        ChessPiece(int PieceType,int Colour)
        {
            chessPiece = PieceType;
            chessPieceColour = Colour;
        }

    }
}
