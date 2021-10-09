using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MyMatrixe
{
    internal class MyMatrix
    {
        public int width, height;
        public Object[,] Matrixe;
        public MyMatrix(int wd,int hg)
        {
            width = wd;
            height = hg;
            Matrixe = new Object[width,height];
        }
        public virtual void AddItem(int x,int y,Object obj)
        {
            if(width>x && height>y && obj != null)
            {
                Matrixe[x,y] = obj;
            }
            else
            {
                throw new ArgumentException("Parametr is wrong");
            }
        }
        public virtual Object getItem(int x,int y)
        {
            if (width > x && height > y)
            {
                return Matrixe[x, y];
            }
            else
            {
                throw new ArgumentException("Parametr is wrong");
            }
        }

    }
}
