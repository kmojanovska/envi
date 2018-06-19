using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envi
{
    class MonsterStrong : IMonster
    {

        private int x, y, width, height;
        private int speed { get; set; }
        public Image monsterImage;
        private Rectangle monsterRectangle;
        public int strength;

        public MonsterStrong(int x, int speed)
        {
            this.x = x;
            this.speed = speed;
            y = 0;
            width = 80;
            height = 80;
            strength = 0;
            monsterImage = Properties.Resources.fireball;
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
            if(monsterRectangle.X <= (Form1.ActiveForm.Width / 2))
            {
                monsterRectangle.X += 10;
            }
            else
            {
                monsterRectangle.X -= 10;
            }
            monsterRectangle.Y += speed;
        }

        public override bool Collision(Rectangle bulletRectangle)
        {
            if (monsterRectangle.IntersectsWith(bulletRectangle))
                return true;
            return false;
        }

        public override int GetStrength()
        {
            return strength;
        }

        public override void IncreaseStrength()
        {
            this.strength++;
        }
    }
}
