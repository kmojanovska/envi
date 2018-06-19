using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envi
{
    class MonsterWeek : IMonster
    {
        private int x, y, width, height;
        private int speed;
        public Image monsterImage;
        private Rectangle monsterRectangle;
        public bool areWingsOpen;

        public MonsterWeek(int x, int speed)
        {
            this.x = x;
            this.speed = speed;
            areWingsOpen = true;
            y = 0;
            width = 41;
            height = 20;

            monsterImage = Properties.Resources.monsterWeek;
            monsterRectangle = new Rectangle(x, y, width, height);
        }

        public override Rectangle MonsterRect
        {
            get { return monsterRectangle; }
        }

        public override void DrawMonster(Graphics paper)
        {

            paper.DrawImage(monsterImage, monsterRectangle);
        }

        public override void MoveMonster()
        {
            monsterRectangle.Y += speed;
        }
        

        public override bool Collision(Rectangle bulletRectangle)
        {
            if (monsterRectangle.IntersectsWith(bulletRectangle))
                return true;
            return false;
        }

    }
}
