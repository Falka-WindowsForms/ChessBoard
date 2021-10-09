using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Models;
namespace Chess.MyMatrixe
{
    internal class ChessMatrix : MyMatrix
    {
        int distance_W=0;
        int distance_H=0;

        public ChessMatrix() : base(8, 8)
        {
            this.AddItem(0,0,(new Figure(FiguresType.Pawn,FigureColor.White)));    
            this.AddItem(7,6,(new Figure(FiguresType.Pawn, FigureColor.Black)));    
            this.AddItem(6,6,(new Figure(FiguresType.Pawn, FigureColor.Black)));    
            this.AddItem(5,6,(new Figure(FiguresType.Pawn, FigureColor.Black)));    
            this.AddItem(4,6,(new Figure(FiguresType.Pawn, FigureColor.Black)));    
            this.AddItem(3,6,(new Figure(FiguresType.Pawn, FigureColor.Black)));    
            this.AddItem(5,3,(new Figure(FiguresType.King, FigureColor.Black)));    
            this.AddItem(2,2,(new Figure(FiguresType.King, FigureColor.White)));    
            this.AddItem(7,7,(new Figure(FiguresType.Queen, FigureColor.Black)));    
            this.AddItem(7,0,(new Figure(FiguresType.Queen, FigureColor.White)));    
        }
        public void DrawMatrixe(Graphics g,int PWidth,int PHeigh)
        {
            g.Clear(Color.White);
            int W = PWidth;
            int H = PHeigh;
            int W_Lines = width;
            int H_Lines = height;
            //Finding distance(in pixels) that will be beetwen the lines
            distance_W = (W / (W_Lines))-5;
            distance_H = (H / (H_Lines)) - 5;
            /////////////////////////////////////////////////
            //Making rectangles
            int temp_W = 10;
            int temp_H = 10;
            for (int x = 0; x < W_Lines; x++)
            {
                for (int y = 0; y < H_Lines; y++)
                {
                    if (Matrixe[x, y] != null)
                    {
                        int startXPosition = temp_W + 10;
                        int startYPosition = temp_H + 10;
                        int endXPosition = temp_W + distance_W - 10;
                        int endYPosition = temp_H + distance_H - 10;
                        Rectangle temp_rect = new Rectangle(new Point(startXPosition, startYPosition), new Size(endXPosition - startXPosition, endYPosition - startYPosition));
                        Figure figure = (Figure)Matrixe[x, y];
                        if (figure.figureType == FiguresType.Pawn)
                        {
                            //Drawing pawn
                            if(figure.figureColor == FigureColor.Black)
                                g.DrawImage(Image.FromFile(@"..\..\Images\black_pawn.png"), temp_rect);
                            else
                                g.DrawImage(Image.FromFile(@"..\..\Images\white_pawn.png"), temp_rect);
                        }
                        else if(figure.figureType == FiguresType.King)
                        {
                            if (figure.figureColor == FigureColor.Black)
                                g.DrawImage(Image.FromFile(@"..\..\Images\black_king.png"), temp_rect);
                            else
                                g.DrawImage(Image.FromFile(@"..\..\Images\white_king.png"), temp_rect);
                        }else if(figure.figureType == FiguresType.Queen)
                        {
                            if (figure.figureColor == FigureColor.Black)
                                g.DrawImage(Image.FromFile(@"..\..\Images\black_queen.png"), temp_rect);
                            else
                                g.DrawImage(Image.FromFile(@"..\..\Images\white_queen.png"), temp_rect);

                        }
                    }
                    Rectangle rect = new Rectangle(new Point(temp_W, temp_H), new Size(distance_W,distance_H));
                    g.DrawRectangle(new Pen(Brushes.Purple, 2), rect);
                    temp_H += distance_H;
                }
                temp_H = 10;
                temp_W += distance_W;
            }
            
        }

        public FiguresType getFigureOnPosition(int x,int y)
        {
            int posX = x / distance_W;
            int posY = y / distance_H;
            if (posX < 8 && posY < 8)
            {
                if (Matrixe[posX, posY] != null)
                    return ((Figure)(Matrixe[posX, posY])).figureType;
                else
                    return FiguresType.None;
            }
            else
                return FiguresType.None;
        }
    }
}
