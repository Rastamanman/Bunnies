using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iepuri
{
    interface IBunny
    {
        void changeDir();
        bool searchEgg();
        void collectEgg(IEgg egg);
        bool isInField(IField field);
    }
}
