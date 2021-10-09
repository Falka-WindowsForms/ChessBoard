using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chess.MyMatrixe;
namespace Chess
{
    public partial class Form1 : Form
    {
        ChessMatrix chessMatrix = new ChessMatrix();
        public Form1()
        {
            InitializeComponent();
        }
        bool drawFlag = false;
        private void DrawChessBoard()
        {
            drawFlag = true;
            viewBox.Image = null;
            viewBox.Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DrawChessBoard();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (drawFlag == true)
            {
                chessMatrix.DrawMatrixe(e.Graphics,viewBox.Width, viewBox.Height);
               
            }
            
            drawFlag = false;
        }



        private void viewBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Models.FiguresType type = chessMatrix.getFigureOnPosition(e.X, e.Y);
                if (type == Models.FiguresType.Pawn)
                    PawContexMenu.Show(Cursor.Position);
                else if(type == Models.FiguresType.King)
                    KingContexMenu.Show(Cursor.Position);
                else if(type == Models.FiguresType.Queen)
                    QueenContextMenu.Show(Cursor.Position);
            }
        }
    }
}
