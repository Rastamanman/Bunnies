using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iepuri
{
    class Parcel: IParcel
    {
        private List<IEgg> eggs = new List<IEgg>();

        public void addEgg(IEgg egg)
        {
            eggs.Add(egg);
        }

        public bool isOuter()
        {
            return false;
        }

        public bool isEmpty()
        {
            return eggs.Count <= 0;
        }

        public IEgg collectEgg()
        {
            IEgg returned = eggs.First();
            eggs.RemoveAt(0);
            return returned;
        }
    }
}
