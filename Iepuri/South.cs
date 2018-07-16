using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iepuri
{
    class South: IDirection
    {
        public Position move()
        {
            return new Position(0, 1);
        }

        public IDirection change()
        {
            return new West();
        }
    }
}
