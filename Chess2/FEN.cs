using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Chess2
{
    class FEN
    {
        Board InitialBoard = new Board();
        public void FENString(string FENString )
        {
            Dictionary<char,int> FENStringDictionary = new Dictionary<char , int>() {              
                {'k',Piece.King },
                {'q',Piece.Queen },
                {'r',Piece.Rook },
                {'n',Piece.Knight },
                {'b',Piece.Bishop },
                {'p',Piece.Pawn }
            };
            int PositionX = 5;
            int PositionY = 3;
            foreach( char character in FENString)
            {
                if (FENStringDictionary.ContainsKey(character))
                {
                    InitialBoard.AddPiece(PositionX, PositionY, FENStringDictionary[character]);
                 
                }
            }



        }   


    }
}
