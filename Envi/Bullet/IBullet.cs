using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    public abstract class IBullet
    {

        public int x;
        public int y;
        private Rectangle bulletRectangle;

        public virtual Rectangle BulletRect
        {
            get { return bulletRectangle; }
        }

        public virtual void DrawBullet(Graphics paper) { }

        public virtual void MoveBullet(int charY, int charX) { }
    }
}
