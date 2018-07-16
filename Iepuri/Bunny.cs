using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iepuri
{
    class Bunny: IBunny
    {
        private Position pos;
        private IDirection direction;
        private int score;

        public Bunny(Position p, IDirection dir)
        {
            pos = p;
            direction = dir;
            score = 0;
        }

        public void move()
        {
            pos += direction.move();
        }
        
        public void changeDir()
        {
            direction = direction.change();
        }

        public bool searchEgg()
        {
            return true;
        }

        public void collectEgg(IEgg egg)
        {
            changeDir();
            score = egg.addValue(score);
        }

        public bool isInField(IField field)
        {
            return field.haveThis(pos);
        }

    }
}
