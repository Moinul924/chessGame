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
