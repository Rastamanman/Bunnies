using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iepuri
{
    class Position
    {
        private int x;
        private int y;

        public Position(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static Position operator+(Position source, Position add)
        {
            return new Position (source.x += add.x, source.y += add.y);
        }

        public bool inMatrix(int width, int height)
        {
            return (y < height && y >= 0) && (x < width && x >= 0); 
        }
    }
}
