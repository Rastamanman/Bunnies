using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iepuri
{
    class Field: IField
    {
        private IParcel[,] field;
        private int height, width;

        public Field(int h, int w)
        {
            height = h;
            width = w;
            field = new Parcel[w, h];
        }

        public bool haveThis(Position pos)
        {
            return pos.inMatrix(width, height);
        }
    }
}
