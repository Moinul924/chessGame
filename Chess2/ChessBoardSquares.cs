using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess2
{
    public class ChessBoardSquares : PictureBox
    {
        public int SquarePositionX { get; set; }
        public int SquarePositionY { get; set; }
        public ChessPiece chessPiece  { get; set; }

        public void RemoveChessPiece()
        {
           
        }
       
    }
}
