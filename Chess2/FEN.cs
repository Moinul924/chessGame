using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chess2
{
    public class FEN:Board
    {
        public void FENString(string FENString )
        {
            Dictionary<char,string> FENStringDictionary = new Dictionary<char , string>() {
                {'K',"WKing.png" },
                {'Q',"WQueen.png" },
                {'R',"WRook.png" },
                {'N',"WKight.png" },
                {'B',"WBishop.png" },
                {'P',"WPawn.png" },
                {'k',"BKing.png" },
                {'q',"BQueen.png" },
                {'r',"BRook.png" },
                {'n',"BKight.png" },
                {'b',"BBishop.png" },
                {'p',"BPawn.png" }
            };
            int PositionX = 0;
            int PositionY = 0;
            foreach( char character in FENString)
            {
                if (FENStringDictionary.ContainsKey(character))
                {
                    //ChessPiece chessPiece = new ChessPiece(Piece.Rook,Piece.Black);
                }
            }



        }   


    }
}
