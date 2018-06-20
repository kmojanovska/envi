using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    class BulletType1 : IBullet
    {
        private int width, height;
        private int speed;
        public Image bulletImage;
        private Rectangle bulletRectangle;
        public override Rectangle BulletRect
        {
            get { return bulletRectangle; }
        }

       
        public BulletType1(int x, int y, int speed, string name)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;

            width = 20;
            height = 20;
            if(name == "thor")
            {
                bulletImage = Envi.Properties.Resources.hammer;
            }
            else
            {
                bulletImage = Envi.Properties.Resources.fire;
            }
            bulletRectangle = new Rectangle(x, y, width, height);
        }

        public override void DrawBullet(Graphics paper)
        {
            paper.DrawImage(bulletImage, bulletRectangle);
        }

        public override void MoveBullet(int charY, int charX)
        {

            if (bulletRectangle.Y < 50)
            {

                bulletRectangle.Y += 500;

                bulletRectangle.X = charX;
            }
            bulletRectangle.Y -= speed;
        }

    }
}
