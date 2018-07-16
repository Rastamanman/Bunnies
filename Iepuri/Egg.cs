using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iepuri
{
    class Egg: IEgg
    {
        private int value;

        public int addValue(int a)
        {
            return a + value;
        }

        public Egg(int v = 0)
        {
            value = v;
        }
    }
}
