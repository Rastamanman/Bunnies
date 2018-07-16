using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iepuri
{
    class East: IDirection
    {
        public Position move()
        {
            return new Position(1, 0);
        }

        public IDirection change()
        {
            return new South();
        }
    }
}
