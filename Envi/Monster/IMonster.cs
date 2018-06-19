using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    public abstract class IMonster
    {
        private Rectangle monsterRectangle;

        public virtual Rectangle MonsterRect
        {
            get { return monsterRectangle; }
        }

        public virtual void DrawMonster(Graphics paper){}
        
        public virtual void MoveMonster(){}

        public virtual bool Collision(Rectangle bulletRectangle)
        {
            return false;
        }
        public virtual int GetStrength() { return 1; }

        public virtual void IncreaseStrength(){}
    }
}
