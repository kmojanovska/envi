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
        public int x;
        public int y;
        private int width, height;
        private int speed;
        public Image bulletImage;
        public Rectangle bulletRectangle;
        public Rectangle BulletRect
        {
            get { return bulletRectangle; }
        }

       
        public BulletType1(int x, int y, int speed)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;

            width = 20;
            height = 20;

            bulletImage = Envi.Properties.Resources.fire;
            bulletRectangle = new Rectangle(x, y, width, height);
        }

        public void DrawBullet(Graphics paper)
        {
            paper.DrawImage(bulletImage, bulletRectangle);
        }

        public void MoveBullet(int charY, int charX)
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
