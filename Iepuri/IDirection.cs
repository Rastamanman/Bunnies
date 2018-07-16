using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iepuri
{
    interface IDirection
    {
        Position move();
        IDirection change();
    }
}