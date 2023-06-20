using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess2
{
    public partial class Form1 : Form
    {
        public Image PieceCopied;
        public int PreviousLocationX;
        public int PreviousLocationY;
        public bool moveMade = false;
        public int SquareSize = 80;
        public static Color LightColor = ColorTranslator.FromHtml("#A97A65");
        public static Color DarkColor = ColorTranslator.FromHtml("#F1D9C0");

        public Form1()
        {
            InitializeComponent();
            DrawBoard();
        }
        public void DrawBoard()
        {


            for (int file = 0; file < 8; file++)
            {
                for (int rank = 0; rank < 8; rank++)
                {
                    // Create picture box for pieces
                    var NewBoardSquares = new ChessBoardSquares
                    {
                        Size = new Size(SquareSize, SquareSize),
                        Location = new Point(SquareSize * file + 180, SquareSize * rank + 60),
                        AllowDrop = true,
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        SquarePositionX = file,
                        SquarePositionY = rank,
                        chessPiece = null,
                        
                    };
                    if ((rank + file) % 2 == 0)
                    {
                       NewBoardSquares.BackColor = DarkColor;
                    }
                    else
                    {
                        NewBoardSquares.BackColor = LightColor;
                    }
                    this.Controls.Add(NewBoardSquares);
                    Board.ChessBoard[file,rank] = NewBoardSquares;
                    NewBoardSquares.MouseEnter += new EventHandler(MouseEnter);
                    NewBoardSquares.MouseLeave += new EventHandler(MouseLeave);
                    NewBoardSquares.MouseDown += new MouseEventHandler(MouseDown);
                    NewBoardSquares.MouseUp += new MouseEventHandler(MouseUp);

                  


                    
                }
            }
            
            
        }

        
           
                
        

        new void MouseEnter(object sender, EventArgs e)
        {
            ChessBoardSquares currentPictureBox = (ChessBoardSquares)sender;
            int locationX = currentPictureBox.SquarePositionX;
            int locationY = currentPictureBox.SquarePositionY;
            if (PieceCopied != null)
            {
                Board.AddPiece(PieceCopied, locationX, locationY);
                PieceCopied = null;
                this.Cursor = Cursors.Default;
            }
           
        }
        new void MouseLeave(object sender, EventArgs e)
        {
            ChessBoardSquares currentPictureBox = (ChessBoardSquares)sender;
            int locationX = currentPictureBox.SquarePositionX;
            int locationY = currentPictureBox.SquarePositionY;
            


        }
        new void MouseDown(object sender, EventArgs e)
        {
  
            ChessBoardSquares currentPictureBox = (ChessBoardSquares)sender;
            int locationX = currentPictureBox.SquarePositionX;
            int locationY = currentPictureBox.SquarePositionY;
            PreviousLocationX = locationX;
            PreviousLocationY = locationY;
            
            if (currentPictureBox.Image != null)
            {
                Bitmap bmp = (Bitmap)currentPictureBox.Image;
                this.Cursor = new Cursor(bmp.GetHicon());
                PieceCopied = Board.ChessBoard[locationX, locationY].Image;
                Board.RemovePiece(locationX, locationY);

            }
        }
        new void MouseUp(object sender, EventArgs e)
        {
            ChessBoardSquares currentPictureBox = (ChessBoardSquares)sender;
            int locationX = currentPictureBox.SquarePositionX;
            int locationY = currentPictureBox.SquarePositionY;
          
            
               
            if (currentPictureBox.ClientRectangle.Contains(currentPictureBox.PointToClient(Control.MousePosition)) & PieceCopied != null)
            {
                Board.AddPiece(PieceCopied, locationX, locationY);
                PieceCopied = null;
                this.Cursor = Cursors.Default;
            }
            

        }

        private void MouseOnForm(object sender, EventArgs e)
        {
            if (PieceCopied != null)
            {
                Board.AddPiece(PieceCopied, PreviousLocationX, PreviousLocationY);
                PieceCopied = null;
                this.Cursor = Cursors.Default;
            }
        }
    }
}
