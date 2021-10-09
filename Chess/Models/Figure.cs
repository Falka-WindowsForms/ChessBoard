using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    enum FiguresType {
    Pawn,
    Rook,
    Knight,
    Bishop,
    Queen,
    King,
    None
    }
    enum FigureColor
    {
        White,
        Black
    }
    internal class Figure
    {
        public Figure(FiguresType ft,FigureColor fc) //int x, int y)
        {
            figureType = ft;
            figureColor = fc;
        }
        public FiguresType figureType;
        public FigureColor figureColor;
    }
}
