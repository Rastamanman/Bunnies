using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iepuri
{
    interface IParcel
    {
        bool isOuter();
        bool isEmpty();
        IEgg collectEgg();
    }
}
