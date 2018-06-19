using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    class MonsterMedium : IMonster
    {

        private int x, y, width, height;
        private int speed;
        public int strength;
        public Image monsterImage;
        private Rectangle monsterRectangle;
        public bool isColored;

        public MonsterMedium(int x, int speed)
        {
            this.x = x;
            this.speed = speed;
            isColored = false;
            strength = 0;
            y = 0;
            width = 31;
            height = 30;

            monsterImage = Properties.Resources.Witch;
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

        public int GetStrength()
        {
            return strength;
        }

        public void IncreaseStrength()
        {
            strength++;
        }

    }
}
