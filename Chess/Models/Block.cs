using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    internal class Block
    {
        public int XpostionMatrixe,YpositionMatrixe;
        public int X, Y;
        public Block(int XposM, int YposM, int coordinteX, int coordinateY)
        {
            XpostionMatrixe = XposM;
            YpositionMatrixe = YposM;
            Y = coordinateY;
            X = coordinteX;
        }
    }
}
